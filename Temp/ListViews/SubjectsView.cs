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
    public partial class SubjectsView : UserControl
    {
        Subject su;
        public SubjectsView(Subject sub)
        {
            InitializeComponent();
            subject_credits_lbl.Text = sub.Credit.ToString() ;
            subject_hour_lbl.Text = sub.Hour+"h";
            subject_name_lbl.Text = sub.Name;
            course_name_lbl.Text = sub.Course.Name+" "+HelpMe.GetInitials(sub.Course.Level,"");
            su = sub;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditSubject s = new EditSubject(su);
            s.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            AspireDB db = new AspireDB();
            Subject x = db.Subjects.SingleOrDefault(Subjects => Subjects.SubjectID== su.SubjectID && Subjects.Name == su.Name && Subjects.CourseID == su.CourseID);
            db.Subjects.Remove(x);
            db.SaveChanges();
            SubjectControl.Instance.FooterMessage("Subject Deleted");
            SubjectControl.Instance.CreateList();
        }


    }
}
