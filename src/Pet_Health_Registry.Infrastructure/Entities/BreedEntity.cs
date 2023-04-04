using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("Breed")]
    internal class BreedEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpeciesId { get; set; }

        [ForeignKey("SpeciesId")]
        public SpeciesEntity Species { get; set; }
    }
}
