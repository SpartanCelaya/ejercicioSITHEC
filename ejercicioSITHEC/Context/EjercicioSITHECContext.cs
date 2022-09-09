using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejercicioSITHEC.Models;
using Microsoft.EntityFrameworkCore;

namespace ejercicioSITHEC.Context
{
    public class EjercicioSITHECContext : DbContext
    {
        public EjercicioSITHECContext(DbContextOptions<EjercicioSITHECContext> options):base(options)
        {

        }
        public DbSet<Humano> HumanoItems { get; set; }
    }
}
