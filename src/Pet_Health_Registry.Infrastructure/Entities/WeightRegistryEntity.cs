using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("WeightRegistry")]
    internal class WeightRegistryEntity
    {
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public DateTime RegisterOn { get; set; }
        public int Weight { get; set; }

        [ForeignKey("PetId")]
        public PetEntity Pet { get; set; }
    }
}
