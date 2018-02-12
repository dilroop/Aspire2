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
    public partial class EditStudent : MetroForm
    {
        AspireDB db;
        Student stud;
        public EditStudent(Student s)
        {
            InitializeComponent();
            db = new AspireDB();
            stud = db.Students.SingleOrDefault(Student => Student.ID==s.ID);
            student_name.Text = s.Name;
            student_studentID.Text = s.StudentID;
            student_email.Text = s.Email;
            List<Course> courses_list= db.Courses.ToList<Course>();
            int count = 0,si=0;
            foreach(Course c in courses_list)
            {
                course_combo.Items.Add(c.Name);
                if(c.Name.Equals(s.Course.Name))
                {
                    si = count;
                }
                count++;
            }
            course_combo.SelectedIndex = si;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (student_name.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please enter Student Name!");
                return;
            }

            if (student_studentID.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please enter Student Id!");
                return;
            }

            if (course_combo.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please choose Course Name!");
                return;
            }
            stud.Name = student_name.Text;
            stud.StudentID = student_studentID.Text;
            stud.Email = student_email.Text;
            stud.Course.Name = course_combo.Text;
            db.Entry(stud).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            StudentControl.Instance.FooterMessage("Student Saved");
            StudentControl.Instance.CreateList();

        }
    }
}
