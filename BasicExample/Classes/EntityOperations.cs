using System.Collections.Generic;
using System.Threading.Tasks;
using BasicExample.Contexts;
using BasicExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicExample.Classes
{
    public class EntityOperations
    {
        public static HotelContext Context = new HotelContext();
        /// <summary>
        /// Read rooms from database asynchronously
        /// </summary>
        /// <returns>List of rooms</returns>
        public static async Task<List<Room>> GetRooms()
        {
            var rooms = new List<Room>();

            await Task.Run(async () =>
            {
                rooms = await Context.Room.ToListAsync();

            });

            return rooms;
        }
    }
}
