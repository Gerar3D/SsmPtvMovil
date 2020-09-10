using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SsmPtvMovil.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }

        public ICollection<Store> Stores { get; set; }

        [DisplayName("Stores Number")]
        public int StoresNumber => Stores == null ? 0 : Stores.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdState { get; set; }

    }
}
