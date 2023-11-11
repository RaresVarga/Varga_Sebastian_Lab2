using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Varga_Sebastian_Lab2.Models;

namespace Varga_Sebastian_Lab2.Data
{
    public class Varga_Sebastian_Lab2Context : DbContext
    {
        public Varga_Sebastian_Lab2Context (DbContextOptions<Varga_Sebastian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Varga_Sebastian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Varga_Sebastian_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Varga_Sebastian_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Varga_Sebastian_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Varga_Sebastian_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Varga_Sebastian_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
