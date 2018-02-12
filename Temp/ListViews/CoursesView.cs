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
    public partial class CoursesView : UserControl
    {
        private Course _cs;
        public CoursesView(Course cs)
        {
            InitializeComponent();
            course_level_lbl.Text = cs.Level;
            course_name_lbl.Text = cs.Name;
            strength.Text = cs.Nos.ToString();
            _cs = cs;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditCourse ec = new EditCourse(_cs);
            ec.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            MsgBoxDialog md = new MsgBoxDialog();
            DialogResult result = md.Showw("Deleting Course Will Delete following data as well!\n1. All the Student with same course.\n2. All the Subjects within the course.");
            if (result == DialogResult.OK)
            {
                AspireDB db = new AspireDB();
                Course x = db.Courses.SingleOrDefault(Course => Course.CourseID == _cs.CourseID && Course.Name == _cs.Name && Course.Level == _cs.Level);

                // Deleting Cources
                foreach (Subject s in db.Subjects.Where(Subject => Subject.CourseID == x.CourseID))
                {
                    db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
                }
                db.SaveChanges();

                // Deleting Students
                foreach (Student s in db.Students.Where(Student => Student.CourseID == x.CourseID))
                {
                    db.Entry(s).State = System.Data.Entity.EntityState.Deleted;
                }
                db.SaveChanges();

                // Deleting Course
                db.Entry(x).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                //

                SubjectControl.Instance.CreateList();
                SubjectControl.Instance.FilterBoxUpdate();
                SubjectControl.Instance.FooterMessage(x.Name + " Deleted -> Subjects Deleted ");

                StudentControl.Instance.CreateList();
                StudentControl.Instance.FooterMessage(x.Name + " Deleted -> Students Deleted ");

                CourseControl.Instance.FooterMessage("Course Deleted");
                CourseControl.Instance.CreateList();
            }else
            {

            }

        }

    }
}
