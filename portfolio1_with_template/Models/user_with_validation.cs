using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio1_with_template.Models
{
    public class user_with_validation
    {
        [Required]
        [MinLength(3)]
        public string firstName { get; set; }

        [Required]
        [MinLength(3)]
        public string lastName { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
