using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private SortableBindingList<Room> _bindingListRooms = new SortableBindingList<Room>();
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

            _bindingListRooms = new SortableBindingList<Room>(roomList);
            dataGridView1.DataSource = _bindingListRooms;

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.DataError += DataGridView1_DataError;

        }
        /// <summary>
        /// Handle exceptions like invalid values for a property of a cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((e.Exception) is FormatException)
            {
                var view = (DataGridView)sender;

                view.Rows[e.RowIndex].ErrorText = 
                    $"Invalid value for '{view.CurrentCell.OwningColumn.HeaderText}'";

                e.ThrowException = false;

            }
            else
            {
                /*
                 * for development - figure out how this is to be handled
                 * then assert for it as done with FormatException
                 */
                Console.WriteLine(e.Exception.Message);
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Coupled with DataError event which if an exception is thrown and handled
        /// this clears the error text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var view = (DataGridView)sender;
            view.Rows[e.RowIndex].ErrorText = "";
        }

        /// <summary>
        /// Save changes, assert data is loaded first where in
        /// Example1 project buttons are enabled/disabled dependent
        /// on the state of data loaded or not loaded.
        ///
        /// Optional, use a try/catch on SaveChanges in the event of error
        /// on the database rejecting one or more changes.
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
