using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverObject.Model;
using Microsoft.EntityFrameworkCore;

namespace DriverObject.Model
{
    public class DriverObjectContext : DbContext
    {
        public DriverObjectContext(DbContextOptions<DriverObjectContext> options)
           : base(options)
        {
        }
        public DbSet<DriverObject.Model.Driver> Drivers { get; set; }
    }
}
