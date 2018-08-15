using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagement.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        [MaxLength(3,ErrorMessage ="Reg No. Should Be 3 Digit")]
        [MinLength(3, ErrorMessage = "Reg No. Should Be 3 Digit")]
        [Display(Name="Reg No")]
        public string RegNo { get; set; }  
        
        //[Display(Name="Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
