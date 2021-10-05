using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplicationAPIToangralur
{
    public class RoomContext : DbContext
    {
        //public RoomContext() : base(@"Data Source=LAPTOP-1PJR3MM8\SQLEXPRESS;Initial Catalog=RoomSensorDB;Integrated Security=True")
        public RoomContext() : base(@"Data Source=LAPTOP-1PJR3MM8\SQLEXPRESS;Initial Catalog=RoomSensorDB_Test;Integrated Security=True") // tester dababase
        {
            Database.SetInitializer<RoomContext>(new CreateDatabaseIfNotExists<RoomContext>());

        }

        public DbSet<RoomData> Room { get; set; }
        public DbSet<User> User { get; set; }

    }
}
