using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp.ListViews
{
    public partial class StudentsView : UserControl
    {
        AspireDB db;
        Student stud;
        public StudentsView(Student s)
        {
            InitializeComponent();
            db = new AspireDB();
            stud = db.Students.SingleOrDefault(Student => Student.ID == s.ID);
            student_name.Text = s.Name;
            student_id.Text = s.StudentID;
            course_name.Text = s.Course.Name;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditStudent editcourse = new EditStudent(stud);
            editcourse.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            db.Entry(stud).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            StudentControl.Instance.FooterMessage("Student Deleted");
            StudentControl.Instance.CreateList();
        }
    }
}
