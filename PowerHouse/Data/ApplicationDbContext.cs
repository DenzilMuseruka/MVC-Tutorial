using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PowerHouse.Models;

namespace PowerHouse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PowerHouse.Models.Student> Student { get; set; }
        public DbSet<PowerHouse.Models.Teacher> Teacher { get; set; }
    }
}
