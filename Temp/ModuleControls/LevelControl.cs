using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temp.ListViews;
using Temp.AddForms;

namespace Temp.ModuleControls
{
    public partial class LevelControl : UserControl
    {
        private static LevelControl _instance;
        public static LevelControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LevelControl();
                return _instance;
            }
        }
        
        public LevelControl()
        {
            InitializeComponent();
            CreateList();
        }

        public void CreateList()
        {
            if (levels_layout.Controls.Count > 0)
            {
                levels_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Level> clist = db.Levels.ToList();
            foreach (Level lvl in clist)
            {
                LevelView lv = new LevelView(lvl);
                levels_layout.Controls.Add(lv);
            }
            db.Database.Connection.Close();
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }

        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddLevel instance = new AddLevel();
            instance.ShowDialog();
        }

        private void saveimgbtn_Click(object sender, EventArgs e)
        {
            AspireDB db = new AspireDB();
            db.Configuration.ProxyCreationEnabled = false;
            List<Level> cour = db.Levels.ToList();
            String str = HelpMe.GetJson(cour);
            Console.Write(str);
            HelpMe.SaveFileNow(str, "Levels");
        }

        private void loadimgbtn_Click(object sender, EventArgs e)
        {
            // Opens File and match extension -> If Extension do not match it shows msg
            string json = HelpMe.OpenFileNow("Levels");

            // Load Data from Json File Opened
            List<Level> css = HelpMe.GetDataFromJson<Level>(json);

            AspireDB db = new AspireDB();
            db.Levels.SqlQuery(" DBCC CHECKIDENT('Course', RESEED, 0)");
            int count = 0;
            foreach (Level s in css)
            {
                // Check for Exsisting Subjects
                if (db.Levels.Count(x => x.LevelName == s.LevelName) <= 0)
                {
                    db.Levels.Add(s);
                    count++;
                }
            }

            string msg;
            try
            {
                db.SaveChanges();
                msg = "File Loaded ( " + count + " Rows Added )";
            }
            catch (Exception ee)
            {
                count = 0;
                msg = "File Not Loaded";
                new MsgBox("Invalid File");
                MessageBox.Show(ee.Message);
            }
            //Update list and Show Footer Message
            LevelControl.Instance.CreateList();
            LevelControl.Instance.FooterMessage(msg);
        }
    }
}
