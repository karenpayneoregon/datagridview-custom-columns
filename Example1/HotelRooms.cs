using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Example1.Classes;
using Example1.Controls;
using Example1.Extensions;
using Example1.Models;

namespace Example1
{
    /// <summary>
    /// Notes
    /// - As is there is no sort capability in the DataGridView and is intended.
    ///   Use this component for sorting https://tinyurl.com/y9dgmglv and used
    ///   here https://tinyurl.com/ydysesa2
    /// 
    /// - At first glance reading code without reading the TechNet article may
    ///   not make sense so see the article first.
    /// 
    /// </summary>
    public partial class HotelRoomsWindow : Form
    {
        private BindingList<Room> _bindingListContacts = new BindingList<Room>();
        public HotelRoomsWindow()
        {
            InitializeComponent();

            CurrentRowButton1.Enabled = false;
            CurrentRowButton2.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;

            Shown += HotelRooms_Shown;
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;

        }
        /// <summary>
        /// Keeps track of the DataGridView row index for EditingControlShowing event
        /// </summary>
        private int _currentIndex = 0; 
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _currentIndex = dataGridView1.CurrentRow.Index;
            }
            
            if (e.Control is CalendarEditingControl calendar)
            {
                /*
                 * there is only one here so this assertion is not needed but if there
                 * were more calendar columns then assertion is needed
                 */
                if (dataGridView1.CurrentCell.OwningColumn.Name == "StartDateColumn")
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        var value = _bindingListContacts.StartDate(_currentIndex);
                        Console.WriteLine($"{value:d}");
                    }
                }
            }

            if (e.Control is TimeEditingControl)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var value = _bindingListContacts.StartTime(_currentIndex);
                    Console.WriteLine($"{value:T}");
                }
            }
            
            if (e.Control is DataGridViewTextBoxEditingControl )
            {
                if (dataGridView1.CurrentCell.OwningColumn.Name == "RoomIdentifierColumn")
                {
                    e.Control.KeyPress -= RoomNumber_KeyPress;
                    if (e.Control is TextBox tb)
                    {
                        tb.KeyPress += RoomNumber_KeyPress;
                    }
                }
            }
        }
        /// <summary>
        /// Only permit int values, in this case for RoomIdentifier property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async void HotelRooms_Shown(object sender, EventArgs e)
        {
            var roomList = await EntityOperations.GetRooms();

            _bindingListContacts = new BindingList<Room>(roomList);

            dataGridView1.DataSource = _bindingListContacts;

            CurrentRowButton1.Enabled = true;
            CurrentRowButton2.Enabled = true;
        }
        /// <summary>
        /// Demonstration for BindingList to get current room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentRowButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var room = _bindingListContacts.Values(dataGridView1.CurrentRow.Index);

            MessageBox.Show(room);
        }
        /// <summary>
        /// Demonstration for Room extension to get current room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentRowButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var room = ((Room)dataGridView1.CurrentRow.DataBoundItem).Values();
            MessageBox.Show(room);

        }
        /// <summary>
        /// Demonstration to get all rooms from the DataGridView via DataBoundItem
        /// Also, note this button is not disabled like the first two buttons
        /// as this is an alternate to avoiding a runt time exception.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var allRooms = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.DataBoundItem as Room);

        }
    }
}
