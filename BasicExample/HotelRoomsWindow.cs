using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicExample.Classes;
using BasicExample.Models;

namespace BasicExample
{
    public partial class HotelRoomsWindow : Form
    {
        private BindingList<Room> _bindingListContacts = new BindingList<Room>();
        public HotelRoomsWindow()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Shown += MainForm_Shown;

        }
        /// <summary>
        /// Load three records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Shown(object sender, EventArgs e)
        {
            var roomList = await EntityOperations.GetRooms();

            _bindingListContacts = new BindingList<Room>(roomList);

            dataGridView1.DataSource = _bindingListContacts;

        }
        /// <summary>
        /// Save changes, assert data is loaded first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            EntityOperations.Context.SaveChanges();

        }
    }
}
