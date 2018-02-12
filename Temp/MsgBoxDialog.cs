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
    public partial class MsgBoxDialog : MetroForm
    {
        // Show Message
        public DialogResult Showw(String msg)
        {
            message.Text = msg;
            return ShowDialog();
        }
        public MsgBoxDialog()
        {
            InitializeComponent();
        }

        // Close Message
        private void addbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
