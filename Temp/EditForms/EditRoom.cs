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
    public partial class EditRoom : MetroForm
    {
        AspireDB db;
        Room room;
        public EditRoom(Room rm)
        {
            InitializeComponent();
            db = new AspireDB();
            name.Text = rm.Name.ToString();
            capacity.Text = rm.Capacity.ToString();
            room = db.Rooms.SingleOrDefault(Room => Room.RoomID == rm.RoomID);

        }

        private void updateRoombtn_Click(object sender, EventArgs e)
        {

            room.Name = name.Text;
            room.Capacity = capacity.Text;
            db.Entry(room).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            RoomsControl.Instance.CreateList();
            RoomsControl.Instance.FooterMessage("Room Updated");
        }
    }
}
