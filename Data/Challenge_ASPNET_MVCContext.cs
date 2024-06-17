using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Challenge_ASP.NET_MVC.Models;

namespace Challenge_ASP.NET_MVC.Data
{
    public class Challenge_ASPNET_MVCContext : DbContext
    {
        public Challenge_ASPNET_MVCContext (DbContextOptions<Challenge_ASPNET_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Challenge_ASP.NET_MVC.Models.Article> Article { get; set; } = default!;
    }
}
