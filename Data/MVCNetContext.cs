using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCNet.Models.Entity.User;

namespace MVCNet.Data
{
    public class MVCNetContext : DbContext
    {
        public MVCNetContext (DbContextOptions<MVCNetContext> options)
            : base(options)
        {
        }

        public DbSet<MVCNet.Models.Entity.User.User> User { get; set; } = default!;
    }
}
