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
    public partial class EditSubject : MetroForm
    {
        Subject sub;
        AspireDB db;
        public EditSubject(Subject s)
        {
            InitializeComponent();
            db = new AspireDB();
            subject_credits.Text = s.Credit.ToString();
            subject_hours.Text = s.Hour;
            subject_name.Text = s.Name;
            sub = db.Subjects.SingleOrDefault(Subject => Subject.SubjectID==s.SubjectID && Subject.Name==s.Name);
            
            
            //1 Populating Combo box 
            //2 then selecting the already chosen course
            List<Course> css = db.Courses.ToList();
            int count = 0,si=0;
            foreach (Course c in css)
            {
                course_combo.Items.Add(c.Name + "-" + c.Level);
                if(s.CourseID == c.CourseID)
                {
                    si = count;
                }
                count++;
            }
            course_combo.SelectedIndex = si;
        }

        private void savebtn_Click(object sender, EventArgs e)
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

            sub.Hour = subject_hours.Text;
            sub.Credit = Convert.ToInt32(subject_credits.Text);
            sub.Name = subject_name.Text;

            // parsing Concatinated coursename+level from combobox
            string[] cou = course_combo.Text.Split('-');
            string name = cou[0], level = cou[1];
            Course selected = db.Courses.SingleOrDefault(Course => Course.Name == name && Course.Level == level);
            sub.CourseID = selected.CourseID;
            db.Entry(sub).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            SubjectControl.Instance.FooterMessage("Subject Modified");
            SubjectControl.Instance.CreateList();
        }
    }
}
