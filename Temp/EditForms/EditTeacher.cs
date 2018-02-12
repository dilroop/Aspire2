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
    public partial class EditTeacher : MetroForm
    {
        AspireDB db;
        Teacher teacher;
        public EditTeacher( Teacher tea)
        {
            InitializeComponent();
            db = new AspireDB();
            teacher_name.Text = tea.Name.ToString();
            teacher_contact.Text = tea.Contact.ToString();
            teacher_email.Text = tea.Email.ToString();
           mon_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[0].ToString()));
            mon_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[1].ToString()));
            tues_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[2].ToString()));
            tues_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[3].ToString()));
            wed_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[4].ToString()));
            wed_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[5].ToString()));
            thur_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[6].ToString()));
            thur_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[7].ToString()));
            fri_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[8].ToString()));
            fri_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[9].ToString()));
            sat_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[10].ToString()));
            sat_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[11].ToString()));
            sun_f.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[12].ToString()));
            sun_s.Checked = Convert.ToBoolean(int.Parse(tea.Availability_Time[13].ToString()));
            teacher = db.Teachers.SingleOrDefault(Teacher => Teacher.TeacherID == tea.TeacherID);

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {        
          
            teacher.Name = teacher_name.Text;
            teacher.Contact = teacher_contact.Text;
            teacher.Email = teacher_email.Text;
            teacher.Availability_Time =AvailabilityTime();
            db.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TeachersControl.Instance.CreateList();
            TeachersControl.Instance.FooterMessage("Teacher Updated");

             
        }
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
    }
}
