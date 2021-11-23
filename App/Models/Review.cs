using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models {
    public class Review {
        [Key]
        public int ReviewId { get; set; }

        [MinLength(1)]
        [Required]
        public int Stars { get; set; }

        public OnthaalMoeder OnthaalMoeder { get; set; }
    }
}
