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

namespace Temp.AddForms
{
    public partial class AddLevel : MetroForm
    {
        public AddLevel()
        {
            InitializeComponent();
        }

        private void Addcoursebtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                AspireDB db = new AspireDB();

                Level lvl = new Level();
                string hash = level_name.Text.ToString();
                Level got = db.Levels.SingleOrDefault(x => x.LevelName == hash);
                if (got != null)
                {
                    new MsgBox("Duplicate entry");
                    return;
                }
                lvl.LevelName = level_name.Text.ToString();
                db.Levels.Add(lvl);
                db.SaveChanges();

                message.Text = "Done";
                LevelControl.Instance.CreateList();
                LevelControl.Instance.FooterMessage("Course Added");
            }
        }

        private void level_name_Validating(object sender, CancelEventArgs e)
        {
            level_name.ValidatorTBa(errorProvider1, sender, e);
        }
    }
}
