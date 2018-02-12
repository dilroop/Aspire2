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
    public partial class BatchAddStudent : MetroForm
    {
        Student[] studs;
        AspireDB db;
        public BatchAddStudent()
        {
            InitializeComponent();
            db = new AspireDB();
            course_name.Items.Clear();
            List<Course> css = db.Courses.ToList();
            foreach(Course s in css)
            {
                course_name.Items.Add(s.Name);
            }

            course_level.Items.Clear();
            foreach (string s in HelpMe.levels)
            {
                course_level.Items.Add(s);
            }
            LoadClipboard();
        }
        
        // Loads the Student list from Clipboard
        public void LoadClipboard()
        {
            datagrid.Rows.Clear();
            if(studs!= null && studs.Length>0)
            {
                studs = null;
            }
            
            
            bool invalidparsing = false;
            string[] lines = Clipboard.GetText().ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if(lines.Length<=0)
            {
                new MsgBox("Clipboard Empty");
                return;
            }

            datagrid.Rows.Add(lines.Length);
            studs = new Student[lines.Length];
            int count = 0;
            
            foreach (String line in lines)
            {
                
                string[] list = line.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (list.Length == 2)
                {
                    studs[count] = new Student();
                    studs[count].Name = list[1];
                    studs[count].StudentID = list[0];

                    datagrid.Rows[count].Cells[0].Value = list[0];
                    datagrid.Rows[count].Cells[1].Value = list[1];
                    count++;
                }
                else
                {
                    invalidparsing = true;
                    break;
                }
            }
            if(!invalidparsing)
            {
                datagrid.ClearSelection();
                message.Text = lines.Length.ToString() + (lines.Length==1?" Record":" Records"+" Fetched");
            }
            else
            {
                new MsgBox("Invalid Data");
                message.Text = "Copy And Refresh";
            }
            
        }
        
        // Add Students
        private void addstudentbtn_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                byte[] hash = HelpMe.Md5toBinary(course_name.Text.ToString());
                Course cou = db.Courses.SingleOrDefault(Course => Course.CourseID == hash);
                List<Student> sd = db.Students.ToList();
                int count = 0;
                foreach (Student ed in studs)
                {
                    ed.Course = cou;
                    bool skip = false;
                    foreach (Student d in sd)
                    {

                        if (ed.StudentID==d.StudentID)
                        {
                            skip = true;
                            break;
                        }
                    }
                    if(!skip)
                    {
                        db.Students.Add(ed);
                        count++;
                    }
                }
                db.SaveChanges();
                message.Text="Done";
                StudentControl.Instance.CreateList();
                StudentControl.Instance.FooterMessage(count+" Records Added");
            }
        }

        // refresh clipboard data
        private void refresh_Click(object sender, EventArgs e)
        {
            LoadClipboard();
        }

        // Course name Validator
        private void course_name_Validating(object sender, CancelEventArgs e)
        {
            course_name.ValidatorCB(errorProvider1, sender, e);
        }

        // Course Level Validator
        private void course_level_Validating(object sender, CancelEventArgs e)
        {
            course_level.ValidatorCB(errorProvider1, sender, e);
        }
    }
}
