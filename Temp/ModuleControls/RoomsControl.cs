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
    public partial class RoomsControl : UserControl
    {
        private static RoomsControl _instance;
        public static RoomsControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomsControl();
                return _instance;
            }
        }
        public RoomsControl()
        {
            InitializeComponent();
            CreateList();
        }

        public void CreateList()
        {
            if (rooms_layout.Controls.Count > 0)
            {
                rooms_layout.Controls.Clear();
            }
            AspireDB db = new AspireDB();
            List<Room> tlist = db.Rooms.ToList();
            foreach (Room r in tlist)
            {
                RoomView tv = new RoomView(r);
                rooms_layout.Controls.Add(tv);
            }
            db.Database.Connection.Close();
        }

        public void FooterMessage(string str)
        {
            message.Text = str;
        }

      

        private void addimgbtn_Click(object sender, EventArgs e)
        {
            AddRoom rm = new AddRoom();
            rm.ShowDialog();
        }
    }
}
