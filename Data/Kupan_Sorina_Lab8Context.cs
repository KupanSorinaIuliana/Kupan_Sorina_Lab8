using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kupan_Sorina_Lab8.Models;

namespace Kupan_Sorina_Lab8.Data
{
    public class Kupan_Sorina_Lab8Context : DbContext
    {
        public Kupan_Sorina_Lab8Context (DbContextOptions<Kupan_Sorina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Kupan_Sorina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Kupan_Sorina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Kupan_Sorina_Lab8.Models.Category> Category { get; set; }
    }
}
