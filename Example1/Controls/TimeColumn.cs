using System;
using System.Windows.Forms;

namespace Example1.Controls
{
    public class TimeColumn : DataGridViewColumn
    {
        public TimeColumn() : base()
        {
            base.CellTemplate = new TimeCell();
        }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (!((value == null)) && !(value.GetType().IsAssignableFrom(typeof(TimeCell))))
                {
                    throw new InvalidCastException("Must be a TimeCell");
                }
                base.CellTemplate = value;
            }
        }
    }
    public class TimeCell : DataGridViewTextBoxCell
    {
        public TimeCell()
        {
            Style.Format = "hh:mm tt";
        }
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var timeEditingControl = (TimeEditingControl)DataGridView.EditingControl;
            if (RowIndex >= 0)
            {
                if (!(object.ReferenceEquals(Value, DBNull.Value)))
                {
                    if (Value == null) return;

                    if (Value != "")
                    {
                        try
                        {
                            timeEditingControl.Value = DateTime.Parse(Value.ToString());
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }
            }
        }
        public override Type EditType => typeof(TimeEditingControl);

        public override Type ValueType => typeof(DateTime);

        public override object DefaultNewRowValue => DateTime.Now.ToShortTimeString();
    }
    internal class TimeEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;

        public TimeEditingControl()
        {
            Format = DateTimePickerFormat.Time;
        }
        public object EditingControlFormattedValue
        {
            get => Value.ToShortTimeString();
            set
            {
                if (value is string)
                {
                    Value = DateTime.Parse(Convert.ToString(value));
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return Value.ToShortTimeString();
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ShowUpDown = true;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get => rowIndexNum;
            set => rowIndexNum = value;
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            return key == Keys.Left || key == Keys.Up || 
                   key == Keys.Down || key == Keys.Right || 
                   key == Keys.Home || key == Keys.End || 
                   key == Keys.PageDown || 
                   key == Keys.PageUp;
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }

        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView
        {
            get => dataGridViewControl;
            set => dataGridViewControl = value;
        }

        public bool EditingControlValueChanged
        {
            get => valueIsChanged;
            set => valueIsChanged = value;
        }

        public Cursor EditingControlCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs ea)
        {
            valueIsChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(ea);
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor => IDataGridViewEditingControl_EditingPanelCursor;

        private Cursor IDataGridViewEditingControl_EditingPanelCursor =>
            //throw new Exception("The method or operation is not implemented."); }
            base.Cursor;
    }
}