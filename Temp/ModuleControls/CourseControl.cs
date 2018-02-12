using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temp.ListViews;

namespace Temp
{
    public partial class CourseControl : UserControl
    {
        private static CourseControl _instance;
        public static CourseControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseControl();
                return _instance;
            }
        }
        public CourseControl()
        {
            InitializeComponent();

            LevelChoser.Items.Add("All");
            AspireDB db = new AspireDB();
            foreach (Level l in db.Levels.ToList())
            {
                LevelChoser.Items.Add(l.LevelName);
            }
            LevelChoser.SelectedIndex = 0;

            CreateList();
        }

        public void CreateList()
        {
            string lvl = LevelChoser.GetItemText(LevelChoser.SelectedItem);
            if (lvl.Equals("All"))
            {
                if (courses_layout.Controls.Count > 0)
                {
                    courses_layout.Controls.Clear();
                }
                AspireDB db = new AspireDB();
                List<Course> clist = db.Courses.ToList();
                foreach (Course c in clist)
                {
                    CoursesView cv = new CoursesView(c);
                    courses_layout.Controls.Add(cv);
                }
                db.Database.Connection.Close();
            }
            else
            {
                if (courses_layout.Controls.Count > 0)
                {
                    courses_layout.Controls.Clear();
                }
                AspireDB db = new AspireDB();
                List<Course> clist = db.Courses.Where(x=>x.Level==lvl).ToList();
                foreach (Course c in clist)
                {
                    CoursesView cv = new CoursesView(c);
                    courses_layout.Controls.Add(cv);
                }
                db.Database.Connection.Close();
            }
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }

        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddCourse instance = new AddCourse();
            instance.ShowDialog();
        }

        private void saveimgbtn_Click(object sender, EventArgs e)
        {
            AspireDB db = new AspireDB();
            db.Configuration.ProxyCreationEnabled = false;
            List<Course> cour = db.Courses.ToList<Course>();
            String str = HelpMe.GetJson(cour);
            Console.Write(str);
            HelpMe.SaveFileNow(str, "courses");
        }

        private void loadimgbtn_Click(object sender, EventArgs e)
        {
            // Opens File and match extension -> If Extension do not match it shows msg
            string json = HelpMe.OpenFileNow("courses");

            // Load Data from Json File Opened
            List<Course> css = HelpMe.GetDataFromJson<Course>(json);

            AspireDB db = new AspireDB();
            db.Courses.SqlQuery(" DBCC CHECKIDENT('Course', RESEED, 0)");
            int count = 0;
            foreach (Course s in css)
            {
                // Check for Exsisting Subjects
                if (db.Courses.Count(Course => Course.Name == s.Name && Course.Level == s.Level) <= 0)
                {
                    db.Courses.Add(s);
                    count++;
                }
            }

            string msg;
            try
            {
                db.SaveChanges();
                msg = "File Loaded ( " + count + " Rows Added )";
            }
            catch(Exception ee)
            {
                count = 0;
                msg = "File Not Loaded";
                new MsgBox("Invalid File");
                MessageBox.Show(ee.Message);
            }
            //Update list and Show Footer Message
            CourseControl.Instance.CreateList();
            CourseControl.Instance.FooterMessage(msg);
        }

        private void LevelChoser_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateList();
        }
    }
}
