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
            this.AllButton = new System.Windows.Forms.Button();
            this.CurrentRowButton2 = new System.Windows.Forms.Button();
            this.CurrentRowButton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new Example1.Controls.CalendarColumn();
            this.StartTimeColumn = new Example1.Controls.TimeColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new Example1.Controls.CalendarColumn();
            this.timeColumn1 = new Example1.Controls.TimeColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllButton);
            this.panel1.Controls.Add(this.CurrentRowButton2);
            this.panel1.Controls.Add(this.CurrentRowButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 48);
            this.panel1.TabIndex = 0;
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(188, 13);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(75, 23);
            this.AllButton.TabIndex = 4;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // CurrentRowButton2
            // 
            this.CurrentRowButton2.Location = new System.Drawing.Point(107, 13);
            this.CurrentRowButton2.Name = "CurrentRowButton2";
            this.CurrentRowButton2.Size = new System.Drawing.Size(75, 23);
            this.CurrentRowButton2.TabIndex = 3;
            this.CurrentRowButton2.Text = "Current 2";
            this.CurrentRowButton2.UseVisualStyleBackColor = true;
            this.CurrentRowButton2.Click += new System.EventHandler(this.CurrentRowButton2_Click);
            // 
            // CurrentRowButton1
            // 
            this.CurrentRowButton1.Location = new System.Drawing.Point(12, 13);
            this.CurrentRowButton1.Name = "CurrentRowButton1";
            this.CurrentRowButton1.Size = new System.Drawing.Size(75, 23);
            this.CurrentRowButton1.TabIndex = 2;
            this.CurrentRowButton1.Text = "Current 1";
            this.CurrentRowButton1.UseVisualStyleBackColor = true;
            this.CurrentRowButton1.Click += new System.EventHandler(this.CurrentRowButton1_Click);
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
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "StartDate";
            this.calendarColumn1.HeaderText = "Start";
            this.calendarColumn1.Name = "calendarColumn1";
            // 
            // timeColumn1
            // 
            this.timeColumn1.DataPropertyName = "StartTime";
            this.timeColumn1.HeaderText = "Time";
            this.timeColumn1.Name = "timeColumn1";
            this.timeColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timeColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
        private System.Windows.Forms.Button CurrentRowButton1;
        private System.Windows.Forms.Button CurrentRowButton2;
        private System.Windows.Forms.Button AllButton;
        private CalendarColumn calendarColumn1;
        private TimeColumn timeColumn1;
    }
}