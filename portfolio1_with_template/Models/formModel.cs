using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio1_with_template.Models
{

    public enum myLocations {
        Seattle,
        Chicago,
        Austin,
    }

    public enum Languages
    {
        CSharp,
        Typescript,
        Rust,    
    }

    public class formModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Our Locations")]
        public Enum myLocations { get; set; }
        [Display(Name = "Languages")]
        public Enum Languages { get; set; }
        [Display(Name = "Comment")]

        public string Comment { get; set; }

    }
}
