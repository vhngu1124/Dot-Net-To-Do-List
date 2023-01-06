using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dot_Net_To_Do_List.Models;

namespace Dot_Net_To_Do_List.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dot_Net_To_Do_List.Models.Task> Task { get; set; } = default!;
    }
}
