using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitorManagement.Models;

namespace VisitorManagement.Data
{
    public class VisitorDbContext : DbContext
    {
        // Here we add in all the tables we are using.
        public DbSet<StaffNames> StaffNames { get; set; }
        public DbSet<Visitors> Visitor { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions
        public VisitorDbContext(DbContextOptions<VisitorDbContext> options)
        : base(options)
        {
        }
        public VisitorDbContext()
        {
        }
    }
}
