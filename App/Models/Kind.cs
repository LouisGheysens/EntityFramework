using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models {
    public class Kind {
        [Key]
        public int Id { get; set; }

        [Display(Name ="FullName")]
        [Required]
        public string Name { get; set; }


        public double Length { get; set; }


        [Required]
        public string Geslacht { get; set; }

        public bool IsFlink { get; set; }

        public OnthaalMoeder OnthaalMoeder { get; set; }

    }
}
