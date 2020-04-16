using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LawManagementSystem.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Law> Laws{ get; set; }
        public DbSet<Court> Courts{ get; set; }

        public DbSet<Lawyer> Lawyers{ get; set; }

    }
}
