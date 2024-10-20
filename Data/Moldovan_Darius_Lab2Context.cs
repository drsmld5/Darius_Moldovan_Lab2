using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Darius_Lab2.Models;

namespace Moldovan_Darius_Lab2.Data
{
    public class Moldovan_Darius_Lab2Context : DbContext
    {
        public Moldovan_Darius_Lab2Context (DbContextOptions<Moldovan_Darius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Darius_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Moldovan_Darius_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Moldovan_Darius_Lab2.Models.Author> Authors { get; set; } = default!;
    }
}
