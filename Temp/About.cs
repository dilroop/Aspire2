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
    public partial class About : MetroForm
    {
        // About Form Initialization 
        public About()
        {
            InitializeComponent();
            metroLabel1.Text = "Aspire2 Time Table Generator was build with sole purpose to save time and efforts teacher put in to prepair time tables. \n\n This was Designed and Coded by ";
        }
    }
}
