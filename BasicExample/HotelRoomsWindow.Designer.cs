namespace BasicExample
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new BasicExample.DataGridViewColumns.CalendarColumn();
            this.timeColumn1 = new BasicExample.DataGridViewColumns.TimeColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.RoomIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new BasicExample.DataGridViewColumns.CalendarColumn();
            this.StateDate1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new BasicExample.DataGridViewColumns.TimeColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomIdentifierColumn,
            this.StartDateColumn,
            this.StateDate1Column,
            this.StartTimeColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 108);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 48);
            this.panel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.calendarColumn1.HeaderText = "Start date";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // timeColumn1
            // 
            this.timeColumn1.DataPropertyName = "StartTime";
            this.timeColumn1.HeaderText = "Start time";
            this.timeColumn1.Name = "timeColumn1";
            this.timeColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timeColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Start date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Start time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ep
            // 
            this.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep.ContainerControl = this;
            // 
            // RoomIdentifierColumn
            // 
            this.RoomIdentifierColumn.DataPropertyName = "Identifier";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.RoomIdentifierColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.RoomIdentifierColumn.HeaderText = "Room";
            this.RoomIdentifierColumn.Name = "RoomIdentifierColumn";
            this.RoomIdentifierColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle5.Format = "MM/dd/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.StartDateColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.StartDateColumn.HeaderText = "Start date";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StateDate1Column
            // 
            this.StateDate1Column.DataPropertyName = "StartDate";
            dataGridViewCellStyle6.Format = "MM/dd/yyyy";
            this.StateDate1Column.DefaultCellStyle = dataGridViewCellStyle6;
            this.StateDate1Column.HeaderText = "Start date 1";
            this.StateDate1Column.Name = "StateDate1Column";
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.DataPropertyName = "StartTime";
            this.StartTimeColumn.HeaderText = "Start time";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HotelRoomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 156);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotelRoomsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button SaveButton;
        private DataGridViewColumns.CalendarColumn calendarColumn1;
        private DataGridViewColumns.TimeColumn timeColumn1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomIdentifierColumn;
        private DataGridViewColumns.CalendarColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateDate1Column;
        private DataGridViewColumns.TimeColumn StartTimeColumn;
    }
}

