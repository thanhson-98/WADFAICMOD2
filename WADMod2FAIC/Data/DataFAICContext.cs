using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WADMod2FAIC.Models;

namespace WADMod2FAIC.Models
{
    public class DataFAICContext : DbContext
    {
        public DataFAICContext (DbContextOptions<DataFAICContext> options)
            : base(options)
        {
        }

        public DbSet<WADMod2FAIC.Models.Category> Category { get; set; }

        public DbSet<WADMod2FAIC.Models.Product> Product { get; set; }
    }
}
