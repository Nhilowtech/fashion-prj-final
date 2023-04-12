using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Tacgia
	{
        [Key]
        public string Matacgia { get; set; }
        [Required]
        public string Tentacgia { get; set; }
        public Tacgia()
		{
		}
	}
}

