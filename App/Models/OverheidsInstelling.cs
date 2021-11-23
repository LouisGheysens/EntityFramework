using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models {
    [Table("OpvoedingsCentra")]
    public class OverheidsInstelling {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }


        public string BtwNummer { get; set; }

        [MinLength(5)]
        [Required]
        public string Adres { get; set; }

        public List<OnthaalMoeder> Onthaalmoeders { get; set; } = new List<OnthaalMoeder>();
    }
}
