using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_CRUD_ASP.NET_CORE_3._1.Models
{
    public class Context : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
