using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LearningAndGoverning.Models.ClientModels
{
    public class ClientDetail
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public int ClientSectorId { get; set; }

        public Uri ClientUrl { get; set; }

        public string ClientPhone { get; set; }

        [ForeignKey("ClientSectorId")]
        public virtual ClientSectors ClientSector { get; set; }
    }
}