using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplicationDbContext : DbContext
    {
        public WebApplicationDbContext (DbContextOptions<WebApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Task> Task { get; set; } = default!;
    }
}
