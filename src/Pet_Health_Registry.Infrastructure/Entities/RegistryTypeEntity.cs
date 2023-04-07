using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Health_Registry.Infrastructure.Entities
{
    [Table("RegistryType")]
    internal class RegistryTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
