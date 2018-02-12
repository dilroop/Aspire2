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
using Temp.ModuleControls;

namespace Temp
{
    public partial class Ntecc : MetroForm
    {
        public Ntecc()
        {
            InitializeComponent();
            // Start Admin Module with  Course Module
            BringToFront(CourseControl.Instance);
        }

        // Course Button Click Open Course Module
        private void coursesbtn_Click(object sender, EventArgs e)
        {
            BringToFront(CourseControl.Instance);
        }

        // Subject Button Click Open Subject Module
        private void subjectbtn_Click(object sender, EventArgs e)
        {
            BringToFront(SubjectControl.Instance);
        }

        // Teacher Button Click Open Teacher Module
        private void teacherbtn_Click(object sender, EventArgs e)
        {
            BringToFront(TeachersControl.Instance);
        }

        // Student Button Click Open Student Module
        private void studentbtn_Click(object sender, EventArgs e)
        {
            BringToFront(StudentControl.Instance);
        }

        // Genereate Button Click Open Generate Timetable Module
        private void generatebtn_Click(object sender, EventArgs e)
        {
            BringToFront(GenerateControl.Instance);
        }

        // Rooms Button Click Open Room Module
        private void roombtn_Click(object sender, EventArgs e)
        {
            BringToFront(RoomsControl.Instance);
        }

        private void levelbtn_Click(object sender, EventArgs e)
        {
            BringToFront(LevelControl.Instance);
        }

        // Bring User Control to front - Dilroop
        private void BringToFront(UserControl a)
        {
            if (!content_panel.Controls.Contains(a))
            {
                content_panel.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }

        // Show About Form
        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            About inst = new About();
            inst.ShowDialog();
        }
    }
}
