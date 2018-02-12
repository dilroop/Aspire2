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
using Newtonsoft.Json;

namespace Temp
{
    public partial class SubjectControl : UserControl
    {
        private static SubjectControl _instance;
        public static SubjectControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SubjectControl();
                return _instance;
            }
        }

        public SubjectControl()
        {
            InitializeComponent();
            CreateList();
            FilterBoxUpdate();
            filter_combo.SelectedIndex = 0;
        }

        public void FilterBoxUpdate()
        {
            AspireDB db = new AspireDB();
            List<Course> cs = db.Courses.ToList<Course>();
            filter_combo.Items.Add("All");
            foreach (Course c in cs)
            {
                filter_combo.Items.Add(c.Name + "-" + HelpMe.GetInitials(c.Level, ""));
            }
        }

        public void CreateList()
        {
            if (subject_layout.Controls.Count > 0)
            {
                subject_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Subject> slist = db.Subjects.ToList();
            foreach (Subject c in slist)
            {
                SubjectsView cv = new SubjectsView(c);
                subject_layout.Controls.Add(cv);
            }
            db.Database.Connection.Close();
        }

        public void CreateList(Course c)
        {
            if (subject_layout.Controls.Count > 0)
            {
                subject_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Subject> slist = db.Subjects.Where(Subject=> Subject.CourseID==c.CourseID).ToList<Subject>();
            foreach (Subject s in slist)
            {
                SubjectsView cv = new SubjectsView(s);
                subject_layout.Controls.Add(cv);
            }
            db.Database.Connection.Close();
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }


        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddSubject ins = new AddSubject();
            ins.ShowDialog();
        }

        private void filter_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string item = filter_combo.Text;
            if (!item.Trim().Equals(""))
            {
                if(item.Trim().ToLower().Equals("all"))
                {
                    CreateList();
                }
                else
                {
                    string[] parsed = item.Split('-');
                    string name = parsed[0];
                    string level = HelpMe.GetFullForm(parsed[1]);
                    AspireDB db = new AspireDB();
                    Course c=db.Courses.SingleOrDefault(Course => Course.Name==name && Course.Level==level);
                    CreateList(c);
                }
            }
            else
            {
                CreateList();
            }
        }

        private void saveimgbtn_Click(object sender, EventArgs e)
        {
            AspireDB db = new AspireDB();
            db.Configuration.ProxyCreationEnabled = false;
            List<Subject> sub = db.Subjects.ToList<Subject>();
            
            // Create JSON String
            String str = HelpMe.GetJson(sub);

            // Save in file with extension
            HelpMe.SaveFileNow(str,"subject");
        }

        private void loadimgbtn_Click(object sender, EventArgs e)
        {
            // Opens File and match extension -> If Extension do not match it shows msg
            string json = HelpMe.OpenFileNow("subject");
            
            // Load Data from Json File Opened
            List<Subject> sub = HelpMe.GetDataFromJson<Subject>(json);

            AspireDB db = new AspireDB();

            int count = 0;
            foreach (Subject s in sub)
            {
                // Check for Exsisting Subjects
                if(db.Subjects.Count(Subject => Subject.Name == s.Name && Subject.CourseID == s.CourseID)<=0)
                {
                    db.Subjects.Add(s);
                    count++;
                }                
            }
            
            string msg;
            try { 
            db.SaveChanges();
                msg = "File Loaded ( " + count + " Rows Added )";
            }
            catch
            {
                count = 0;
                msg = "File Not Loaded, Please Make Sure Courses Exsists";
                new MsgBox("Invalid File or Courses Missing!");
            }
            //Update list and Show Footer Message
            SubjectControl.Instance.CreateList();
            SubjectControl.Instance.FooterMessage(msg);
        }
    }
}
