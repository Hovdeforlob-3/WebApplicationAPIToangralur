using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;   

namespace WebApplicationAPIToangralur
{
    public class RoomContext : DbContext
    {
        public RoomContext() : base(@"Data Source=LAPTOP-1PJR3MM8\SQLEXPRESS;Initial Catalog=RoomSensorDB;Integrated Security=True")
        {
            Database.SetInitializer<RoomContext>(new CreateDatabaseIfNotExists<RoomContext>());

        }
        public DbSet<Room> Room { get; set; }
    }
}
