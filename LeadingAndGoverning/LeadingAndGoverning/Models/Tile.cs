using LeadingAndGoverning.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeadingAndGoverning.Models
{
    public class Tile
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        public string ModalText { get; set; }

        [Required]
        [MaxLength(15)]
        public string ModalTitle { get; set; }

        [MaxLength(6)]
        public string ColorCode { get; set; }

        [MaxLength(6)]
        public string GlowColorCode { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public bool deleted { get; set; }

        public Tile()
        {
            Title = string.Empty;
            ModalText = string.Empty;
            ModalTitle = string.Empty;
            ColorCode = string.Empty;
            GlowColorCode = string.Empty;
            ModifiedBy = string.Empty;
            ModifyDate = DateTime.Now;
            deleted = false;
        }
    }
}