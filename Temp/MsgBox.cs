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
    public partial class MsgBox : MetroForm
    {
        // Various constructors for showing custom message box   
        public void Showw(String msg)
        {
            message.Text = msg;
            ShowDialog();
        }

        public MsgBox()
        {
            InitializeComponent();
        }

        public MsgBox(String msg)
        {
            InitializeComponent();
            Showw(msg);
        }

        public MsgBox(String msg,int i)
        {
            InitializeComponent();
            if(i==1)
            {
                icon.Image = Temp.Properties.Resources.icons8_Info_48;
            }
            Showw(msg);
        }

        // Close button Click
        private void addbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
