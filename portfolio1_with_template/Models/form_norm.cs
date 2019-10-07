using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace portfolio1_with_template.Models
{
    public class form_norm
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public List<string> Location { get; set; } = new List<string> { "Vancouver", "Portland", "Spokane" };
        [Required]
        public List<string> FavoriteLanguage { get; set; } = new List<string> { "french", "english", "german" };
        [MinLength(20)]
        public string Comment { get; set; }


    }
}
