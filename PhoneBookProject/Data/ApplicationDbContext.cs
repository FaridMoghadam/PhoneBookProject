using Microsoft.EntityFrameworkCore;
using PhoneBookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<DepartmantList> Depatmantlist { get; set; }

        public DbSet<DataPhonelist> DataPhonelist { get; set; }
    }
}
