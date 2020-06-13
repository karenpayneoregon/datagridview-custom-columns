using System.Collections.Generic;
using System.Threading.Tasks;
using Example1.Contexts;
using Example1.Models;
using Microsoft.EntityFrameworkCore;

namespace Example1.Classes
{
    public class EntityOperations
    {
        /// <summary>
        /// Read rooms from database asynchronously
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Room>> GetRooms()
        {
            var rooms = new List<Room>();

            await Task.Run(async () =>
            {
                using (var context = new HotelContext())
                {
                    rooms = await context.Room.AsNoTracking().ToListAsync();
                }
            });

            return rooms;
        }
    }
}
