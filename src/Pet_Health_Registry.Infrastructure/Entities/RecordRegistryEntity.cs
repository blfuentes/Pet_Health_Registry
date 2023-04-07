using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("RecordRegistry")]
    internal class RecordRegistryEntity
    {
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public int RegistryTypeId { get; set; }
        public DateTime RegisterOn { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        [ForeignKey("PetId")]
        public PetEntity Pet { get; set; }
        [ForeignKey("RegistryTypeId")]
        public RegistryTypeEntity RegistryType { get; set; }
    }
}
