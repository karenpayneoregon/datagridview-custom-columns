using System;
using System.ComponentModel;
using Example1.Models;

namespace Example1.Extensions
{
    public static class BindingListExtensions
    {
        /// <summary>
        /// Get primary key for current row
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position">Current DataGridView row</param>
        /// <returns></returns>
        public static int Identifier(this BindingList<Room> list, int position) => list[position].RoomIdentifier;
        /// <summary>
        /// Get start date for current row
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position">Current DataGridView row</param>
        /// <returns></returns>
        public static DateTime? StartDate(this BindingList<Room> list, int position) => list[position].StartDate;
        /// <summary>
        /// Get start time for current row
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position">Current DataGridView row</param>
        /// <returns></returns>
        public static DateTime? StartTime(this BindingList<Room> list, int position) => list[position].StartTime;
        /// <summary>
        /// Shows values for current row for debug purposes
        /// </summary>
        /// <param name="list"></param>
        /// <param name="position">Current DataGridView row</param>
        /// <returns></returns>
        public static string Values(this BindingList<Room> list, int position)
        {
            var room = list[position];

            return $"Key:{room.RoomIdentifier}\nNumber: " + 
                   $"{room.Identifier}\nDate: {room.StartDate:d}\nTime: {room.StartTime:T}";
        }
    }
}
