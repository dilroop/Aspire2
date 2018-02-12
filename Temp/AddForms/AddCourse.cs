using MetroFramework.Controls;
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
    public partial class AddCourse : MetroForm
    {
        public AddCourse()
        {
            InitializeComponent();
            AspireDB db = new AspireDB();
            foreach (Level l in db.Levels.ToList())
            {
                course_level.Items.Add(l.LevelName);
            }
        }

        // Add Course Module
        private void Addcoursebtn_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                AspireDB db = new AspireDB();

                Course cs = new Course();
                byte[] hash = HelpMe.Md5toBinary(course_name.Text.ToString());
                Course got = db.Courses.SingleOrDefault(Course => Course.CourseID ==hash);
                if (got != null)
                {
                    new MsgBox("Duplicate entry");
                    return;
                }
                cs.Name = course_name.Text.ToString();
                cs.CourseID = hash;
                cs.Level = course_level.Text;
                cs.Nos = Convert.ToInt32(course_strength.Text);
                db.Courses.Add(cs);
                db.SaveChanges();

                message.Text = "Done";
                course_strength.Text = "";
                course_name.Text = "";
                course_level.Text = "";
                CourseControl.Instance.CreateList();
                CourseControl.Instance.FooterMessage("Course Added");
                
            }
        }

        
        private void course_name_Validating(object sender, CancelEventArgs e)
        {
            //for validating any metro textbox for alphabets only
            course_name.ValidatorTBa(errorProvider, sender, e); 
        }

        private void course_strength_Validating(object sender, CancelEventArgs e)
        {
            //for validating any metro textbox for numbers only only
            course_strength.ValidatorTBn(errorProvider, sender, e);
        }

        private void course_level_Validating(object sender, CancelEventArgs e)
        {
            //for couse level validation
            course_level.ValidatorCB(errorProvider,sender,e);
        }
    }
}
