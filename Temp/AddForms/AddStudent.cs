using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class AddStudent : MetroForm
    {
        AspireDB db;
        public AddStudent()
        {
            InitializeComponent();
            db = new AspireDB();
            List<Course> cs=db.Courses.ToList<Course>();
            foreach(Course c in cs)
            {
                course_combo.Items.Add(c.Name+"-"+HelpMe.GetInitials(c.Level,""));
            }
        }
        
        // Add student method
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                Student stud = new Student();
                stud.Name = student_name.Text;
                stud.StudentID = student_studentID.Text;
                stud.Email = student_email.Text;
                string toparse = course_combo.Text;
                string[] strs = toparse.Split('-');
                string cname = strs[0], clevel = HelpMe.GetFullForm(strs[1]);
                Course fc = db.Courses.SingleOrDefault(Course => Course.Name == cname && Course.Level == clevel);
                stud.Course = fc;
                db.Students.Add(stud);
                db.SaveChanges();

                student_email.Text = "";
                student_name.Text = "";
                student_studentID.Text = "";
                StudentControl.Instance.CreateList();
                StudentControl.Instance.FooterMessage("Student Added");
            }
        }

        //Student name validator
        private void student_name_Validating(object sender, CancelEventArgs e)
        {
            ((MetroTextBox)sender).ValidatorTBa(errorProvider1, sender, e);
        }

        //Student email validator
        private void student_email_Validating(object sender, CancelEventArgs e)
        {
            student_email.ValidatorEmail(errorProvider1, sender, e);
        }

        //Student course  validator
        private void course_combo_Validating(object sender, CancelEventArgs e)
        {
            course_combo.ValidatorCB(errorProvider1, sender, e);
        }

        //Student Id validator
        private void student_id_Validating(object sender, CancelEventArgs e)
        {
            student_studentID.ValidatorTBa(errorProvider1, sender, e);
        }
    }
}
