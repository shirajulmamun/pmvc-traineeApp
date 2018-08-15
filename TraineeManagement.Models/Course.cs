using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public List<Trainee> Trainees { get; set; }

    }
}
