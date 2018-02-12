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
    public partial class EditCourse : MetroForm
    {
        Course c;
        AspireDB db;
        public EditCourse(Course cs)
        {
            InitializeComponent();
            db = new AspireDB();
            foreach (Level l in db.Levels.ToList())
            {
                course_level.Items.Add(l.LevelName);
            }
            c = db.Courses.SingleOrDefault(Course => Course.CourseID ==cs.CourseID && Course.Name == cs.Name && Course.Level == cs.Level);
            course_level.Text = c.Level;
            course_name.Text = c.Name;
            course_strength.Text = c.Nos.ToString();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (course_level.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please choose Course Level!");
                return;
            }

            if (course_name.Text.ToString().Trim().Equals(""))
            {
                new MsgBox("Please choose Course Name!");
                return;
            }

            c.Level = course_level.Text;
            c.Name = course_name.Text;
            c.Nos = Convert.ToInt32(course_strength.Text);
            db.Entry(c).State=System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            CourseControl.Instance.FooterMessage("Course Modified");
            CourseControl.Instance.CreateList();
        }
    }
}
