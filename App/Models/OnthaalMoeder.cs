using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models {
    public class OnthaalMoeder {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adres { get; set; }

        public string BtwNummer { get; set; }

        public string Region { get; set; }

        public List<Kind> Kinderen { get; set; } = new List<Kind>();

        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
