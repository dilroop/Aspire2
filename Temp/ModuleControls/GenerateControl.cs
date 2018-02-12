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
    public partial class GenerateControl : UserControl
    {
        private static GenerateControl _instance;
        public static GenerateControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenerateControl();
                return _instance;
            }
        }
        public GenerateControl()
        {
            InitializeComponent();
        }
    }
}
