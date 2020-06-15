using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicExample.Models
{
    /// <summary>
    /// Represents a fictitious hotel room not well structured,
    /// the structure conforms to demonstrates custom DataGridView
    /// columns.  
    /// </summary>
    public partial class Room : INotifyPropertyChanged
    {
        private int? _identifier;
        private DateTime? _startDate;
        private DateTime? _startTime;
        public int RoomIdentifier { get; set; }

        public int? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged();
            }
        }

        public DateTime? StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                _startTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime? StartTime
        {
            get => _startTime;
            set
            {
                _startTime = value;
                _startDate = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => RoomIdentifier.ToString();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}