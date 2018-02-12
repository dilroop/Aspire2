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
    public partial class AddRoom : MetroForm
    {
        AspireDB db;
        public AddRoom()
        {
            InitializeComponent();
        }
        // Add Room method
        private void Addcoursebtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                db = new AspireDB();
                Room x = new Room();
                Room rm= db.Rooms.SingleOrDefault(Room => Room.Name==name.Text.ToString() && Room.Capacity==capacity.Text.ToString() );
                if (rm != null)
                {
                    new MsgBox("Duplicate Room Entry");
                    return;
                }
                x.Capacity = capacity.Text; ;
                x.Name = name.Text;

                db.Rooms.Add(x);
                db.SaveChanges();
                RoomsControl.Instance.CreateList();
                RoomsControl.Instance.FooterMessage("Room Added");
                name.Text = "";
                capacity.Text = "";
                message.Text = "Done";
            }
        }

        //Room capacity validator
        private void capacity_Validating(object sender, CancelEventArgs e)
        {
            capacity.ValidatorTBn(errorProvider1, sender, e);
        }

        //Room name validator
        private void name_Validating(object sender, CancelEventArgs e)
        {
            name.ValidatorTBa(errorProvider1, sender, e);
        }
    }
}
