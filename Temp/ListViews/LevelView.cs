using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temp.ModuleControls;

namespace Temp.ListViews
{
    public partial class LevelView : UserControl
    {
        private Level _lvl;
        public LevelView(Level lvl)
        {
            InitializeComponent();
            level_lbl.Text = lvl.LevelName;
            _lvl = lvl;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            MsgBoxDialog md = new MsgBoxDialog();
            DialogResult result = md.Showw("Are you sure ?");
            if (result == DialogResult.OK)
            {
                try
                {
                    AspireDB db = new AspireDB();
                    Level l = db.Levels.SingleOrDefault(x => x.LevelName == _lvl.LevelName);
                    db.Levels.Remove(l);
                    db.SaveChanges();

                    LevelControl.Instance.CreateList();
                    LevelControl.Instance.FooterMessage(l.LevelName + " Deleted");
                }
                catch (Exception ee)
                {
                    MsgBoxDialog md2 = new MsgBoxDialog();
                    DialogResult res = md2.Showw("Failed to Delete Level !");
                }
            }
        }
    }
}
