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
    public partial class RoomView : UserControl
    {
        private Room _rm;
        AspireDB db;
        public RoomView(Room rm)
        {
            InitializeComponent();
            room_name_lbl.Text = rm.Name;
            room_capacity_lbl.Text = rm.Capacity;
            _rm = rm;
           
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditRoom er = new EditRoom(_rm);
            er.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            db = new AspireDB();
            Room x = db.Rooms.SingleOrDefault(Room => Room.RoomID == _rm.RoomID);
            db.Rooms.Remove(x);
            db.SaveChanges();
            RoomsControl.Instance.FooterMessage("Room Deleted");
            RoomsControl.Instance.CreateList();
        }
    }
}
