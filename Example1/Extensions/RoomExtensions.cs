using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1.Models;

namespace Example1.Extensions
{
    public static class RoomExtensions
    {
        public static string Values(this Room room)
        {
            return $"Key: {room.RoomIdentifier}\nNumber: " +
                   $"{room.Identifier}\nDate: {room.StartDate:d}\nTime: {room.StartTime:T}";
        }
    }
}
