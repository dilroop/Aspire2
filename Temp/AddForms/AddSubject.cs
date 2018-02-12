using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class AddSubject : MetroForm
    {
        AspireDB db;
        public AddSubject()
        {
            InitializeComponent();
            db = new AspireDB();
            List<Course> css = db.Courses.ToList();
            foreach (Course c in css)
            {
                course_combo.Items.Add(c.Name+"-"+c.Level);
            }
        }

        // Add Course Method
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (subject_credits.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please fill Course Credits!");
                return;
            }

            if (subject_hours.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please allocate hours for subject!");
                return;
            }

            if (subject_name.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please enter a name subject!");
                return;
            }

            if (course_combo.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please choose the course!");
                return;
            }

            Subject s = new Subject();
            s.Hour = subject_hours.Text;
            s.Credit = Convert.ToInt32(subject_credits.Text);
            s.Name = subject_name.Text;
            String[] cou = course_combo.Text.Split('-');
            string cname = cou[0],clevel=cou[1];

            Course cs = db.Courses.SingleOrDefault(Course => Course.Name==cname && Course.Level==clevel);
            s.Course = cs;

            db.Subjects.Add(s);
            db.SaveChanges();
            message.Text = "Done";
            subject_credits.Text = "";
            subject_hours.Text = "";
            subject_name.Text = "";
            course_combo.SelectedIndex = 0;
            SubjectControl.Instance.CreateList();
            SubjectControl.Instance.FooterMessage("Subject Added");
        }
    }
}
