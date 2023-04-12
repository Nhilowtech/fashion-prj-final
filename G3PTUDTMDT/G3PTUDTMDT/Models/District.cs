using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
    public class District
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string TenTP { get; set; }

        [Required]
        public string Phancap { get; set; }

        [Required]
        public int Matinh { get; set; }

        public District()
        {
        }
    }
}

