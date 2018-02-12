using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class TeacherView : UserControl
    {
        private Teacher _ts;
        AspireDB db;
        public TeacherView(Teacher ts)
        {
            InitializeComponent();
            teacher_name_lbl.Text = ts.Name;
            teacher_contact_lbl.Text = ts.Contact;
           _ts = ts;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditTeacher editTeacher = new EditTeacher(_ts);
            editTeacher.ShowDialog();
            

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            db = new AspireDB();
            Teacher x = db.Teachers.SingleOrDefault(Teacher => Teacher.TeacherID == _ts.TeacherID);
            User u = db.Users.SingleOrDefault(p => p.Email == x.Email);
            if(u!=null)
            {
                db.Users.Remove(u);
            }

            db.Teachers.Remove(x);
            db.SaveChanges();
            TeachersControl.Instance.FooterMessage("Teacher Deleted");
            TeachersControl.Instance.CreateList();
        }
    }
}
