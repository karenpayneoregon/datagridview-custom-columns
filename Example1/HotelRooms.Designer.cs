using Example1.Controls;

namespace Example1
{
    partial class HotelRoomsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentRowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new Example1.Controls.CalendarColumn();
            this.StartTimeColumn = new Example1.Controls.TimeColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrentRowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 48);
            this.panel1.TabIndex = 0;
            // 
            // CurrentRowButton
            // 
            this.CurrentRowButton.Location = new System.Drawing.Point(12, 13);
            this.CurrentRowButton.Name = "CurrentRowButton";
            this.CurrentRowButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentRowButton.TabIndex = 2;
            this.CurrentRowButton.Text = "Current";
            this.CurrentRowButton.UseVisualStyleBackColor = true;
            this.CurrentRowButton.Click += new System.EventHandler(this.CurrentRowButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomIdentifierColumn,
            this.StartDateColumn,
            this.StartTimeColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 108);
            this.dataGridView1.TabIndex = 1;
            // 
            // RoomIdentifierColumn
            // 
            this.RoomIdentifierColumn.DataPropertyName = "Identifier";
            this.RoomIdentifierColumn.HeaderText = "Room";
            this.RoomIdentifierColumn.Name = "RoomIdentifierColumn";
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.DataPropertyName = "StartDate";
            this.StartDateColumn.HeaderText = "Start";
            this.StartDateColumn.Name = "StartDateColumn";
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.DataPropertyName = "StartTime";
            this.StartTimeColumn.HeaderText = "Time";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Identifier";
            this.dataGridViewTextBoxColumn1.HeaderText = "Room";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // HotelRoomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 156);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotelRoomsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel rooms";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomIdentifierColumn;
        private CalendarColumn StartDateColumn;
        private TimeColumn StartTimeColumn;
        private System.Windows.Forms.Button CurrentRowButton;
    }
}