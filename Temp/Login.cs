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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        // On Login Click
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string user = username.Text.ToString().Trim().ToLower();
                string pass = password.Text.ToString().Trim().ToLower();

                // Check if Admin
                if (user == "admin" && pass == "admin")
                {
                    Hide();
                    new Ntecc().ShowDialog();
                    Show();
                }
                else
                {
                    // Check  if user exist and is teacher
                    AspireDB db = new AspireDB();
                    User u =db.Users.SingleOrDefault(x=>x.Email==user && x.Password==pass);
                    if(u!=null)
                    {
                        Teacher t = db.Teachers.SingleOrDefault(x => x.Email == u.Email);
                        Hide();
                        new TeacherHome(t).ShowDialog();
                        Show();
                        
                    }else
                    {
                        new MsgBox("User Does not Exsist");
                    }
                }
            }
        }

    }

}
