using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModel
{
   public class VmStudent
    {
        [Key]
        
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Coures")]
        public string Coures { get; set; }
        [Required(ErrorMessage = "Please enter RollNo")]
        public string RollNo { get; set; }
        [Required(ErrorMessage = "Please enter Batch")]
        public int Batch { get; set; }
    }
}
