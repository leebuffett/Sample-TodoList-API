using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp.netCore.Models;

namespace asp.netCore.Data
{
    public class aspnetCoreContext : DbContext
    {
        public aspnetCoreContext (DbContextOptions<aspnetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<asp.netCore.Models.Movie> Movie { get; set; }
    }
}
