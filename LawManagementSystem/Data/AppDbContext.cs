using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LawManagementSystem.ViewModels;

namespace LawManagementSystem.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Law> Laws{ get; set; }
        public DbSet<Court> Courts{ get; set; }
        public DbSet<UserCase> UserCase { get; set; }
        public DbSet<Lawyer> Lawyers{ get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<LawManagementSystem.ViewModels.AdminCasesViewModel> AdminCasesViewModel { get; set; }

    }
}
