using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test6_FinalTest.Models;

namespace Test6_FinalTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test6_FinalTest.Models.CompanyNTS999> CompanyNTS999 { get; set; } = default!;

        public DbSet<Test6_FinalTest.Models.NTS0999> NTS0999 { get; set; } = default!;
    }
}
