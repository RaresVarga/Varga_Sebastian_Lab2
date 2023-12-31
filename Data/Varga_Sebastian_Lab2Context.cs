﻿using System;
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
    }
}
