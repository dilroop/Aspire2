using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temp.ListViews;

namespace Temp
{
    public partial class StudentControl : UserControl
    {
        private static StudentControl _instance;
        public static StudentControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentControl();
                return _instance;
            }
        }
        public StudentControl()
        {
            InitializeComponent();
            CreateList();
        }


        public void CreateList()
        {
            if (student_layout.Controls.Count > 0)
            {
                student_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Student> stulist = db.Students.ToList();
            foreach (Student s in stulist)
            {
                StudentsView sv = new StudentsView(s);
                student_layout.Controls.Add(sv);
            }
            db.Database.Connection.Close();
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }


        private void addmultipleimgbtn_Click(object sender, EventArgs e)
        {
            BatchAddStudent bas = new BatchAddStudent();
            bas.ShowDialog();
        }

        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddStudent ins = new AddStudent();
            ins.ShowDialog();
        }

        private void saveimgbtn_Click(object sender, EventArgs e)
        {
            new MsgBox("File Saving Failed !");
        }
    }
}
