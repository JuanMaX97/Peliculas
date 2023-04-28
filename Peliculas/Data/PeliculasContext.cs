using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Peliculas.Models;

namespace Peliculas.Data
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext (DbContextOptions<PeliculasContext> options)
            : base(options)
        {
        }

        public DbSet<Peliculas.Models.movie> movie { get; set; } = default!;
    }
}
