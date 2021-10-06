using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplicationAPIToangralur
{
    /// <summary>
    /// https://stackoverflow.com/questions/18398356/solving-the-objectcontext-instance-has-been-disposed-and-can-no-longer-be-used
    /// </summary>
    public class RoomContext : DbContext
    {
        //public RoomContext() : base(@"Data Source=LAPTOP-1PJR3MM8\SQLEXPRESS;Initial Catalog=RoomSensorDB;Integrated Security=True")
        public RoomContext() : base(@"Data Source=LAPTOP-1PJR3MM8\SQLEXPRESS;Initial Catalog=RoomSensorDB_Test;Integrated Security=True") // tester dababase
        {
            Database.SetInitializer<RoomContext>(new CreateDatabaseIfNotExists<RoomContext>());

            //Configuration.LazyLoadingEnabled = false;

        }

        public DbSet<RoomData> Room { get; set; }
        public DbSet<User> User { get; set; }

    }
}
