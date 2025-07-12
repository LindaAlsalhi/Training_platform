using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlatform.Core.Entities;

namespace TrainingPlatform.Infrastructure.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Course> Courses => Set<Course>();

    }
}
