using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("Species")]
    internal class SpeciesEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
