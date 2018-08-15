using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeManagement.Models;

namespace TraineeManagement.DatabaseContext
{
    public class TraineeDbContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
