using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {     
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Personagem> WebApiDB { get; set; }
    }
}