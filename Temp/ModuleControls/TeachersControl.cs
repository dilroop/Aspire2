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
    public partial class TeachersControl : UserControl
    {
        private static TeachersControl _instance;
        public static TeachersControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeachersControl();
                return _instance;
            }
        }

        public TeachersControl()
        {
            InitializeComponent();
            CreateList();
        }

        public void CreateList()
        {
            if (teacher_layout.Controls.Count > 0)
            {
                teacher_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Teacher> tlist = db.Teachers.ToList();
            foreach (Teacher t in tlist)
            {
                TeacherView tv = new TeacherView(t);
                teacher_layout.Controls.Add(tv);
            }
            db.Database.Connection.Close();
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }


        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddTeacher instance = new AddTeacher();
            instance.ShowDialog();
        }
    }
}
