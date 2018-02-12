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
    public partial class AddTeacher : MetroForm
    {
        AspireDB db;
        public AddTeacher()
        {
            InitializeComponent();
        }

        // Add Teacher and user for login later
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                db = new AspireDB();
                Teacher teacher = new Teacher();
                teacher.Name = teacher_name.Text;
                teacher.Email = teacher_email.Text;
                teacher.Contact = teacher_contact.Text;

                User u = new User();
                u.Email = teacher.Email;
                u.Password = "Teacher";
                u.Role = "T";
                
                teacher.Availability_Time = AvailabilityTime();

                db.Teachers.Add(teacher);
                db.Users.Add(u);
                db.SaveChanges();
                
                teacher_contact.Text = "";
                teacher_name.Text = "";
                teacher_email.Text = "";
                TeachersControl.Instance.CreateList();
                TeachersControl.Instance.FooterMessage("Teacher Added");
                
            }
        }

        // Get teacher availability string 
        private string AvailabilityTime()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.Append(mon_f.Checked == true ? 1 : 0);
            Sb.Append(mon_s.Checked == true ? 1 : 0);
            Sb.Append(tues_f.Checked == true ? 1 : 0);
            Sb.Append(tues_s.Checked == true ? 1 : 0);
            Sb.Append(wed_f.Checked == true ? 1 : 0);
            Sb.Append(wed_s.Checked == true ? 1 : 0);
            Sb.Append(thur_f.Checked == true ? 1 : 0);
            Sb.Append(thur_s.Checked == true ? 1 : 0);
            Sb.Append(fri_f.Checked == true ? 1 : 0);
            Sb.Append(fri_s.Checked == true ? 1 : 0);
            Sb.Append(sat_f.Checked == true ? 1 : 0);
            Sb.Append(sat_s.Checked == true ? 1 : 0);
            Sb.Append(sun_f.Checked == true ? 1 : 0);
            Sb.Append(sun_s.Checked == true ? 1 : 0);

            return Sb.ToString();

        }

        //Teacher Name validator
        private void teacher_name_Validating(object sender, CancelEventArgs e)
        {
            teacher_name.ValidatorTBa(errorProvider1, sender, e);
        }

        // teacher email validator
        private void teacher_email_Validating(object sender, CancelEventArgs e)
        {
            teacher_email.ValidatorEmail(errorProvider1, sender, e);
        }

        // teacher contact details validator
        private void teacher_contact_Validating(object sender, CancelEventArgs e)
        {
            teacher_contact.ValidatorTBn(errorProvider1, sender, e);
        }
    }
}
