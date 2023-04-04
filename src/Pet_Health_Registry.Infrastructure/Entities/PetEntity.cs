using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("Pets")]
    internal class PetEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AdoptionDate { get; set; }
        public int BreedId { get; set; }
        public DateTime DeathDate { get; set; }

        [ForeignKey("BreedId")]
        public BreedEntity Breed { get; set; }
    }
}
