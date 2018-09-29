using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LearningAndGoverning.Models.ClientModels
{
    public class ClientSectors
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string SectorName { get; set; }

        [NotMapped]
        public List<ClientDetail> Clients { get; set; }
    }
}