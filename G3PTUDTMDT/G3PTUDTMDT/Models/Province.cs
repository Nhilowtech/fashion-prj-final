using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Province
	{
        [Key]
        public int Matinh { get; set; }
        [Required]
        public string Tentinh { get; set; }
        public Province()
		{
		}
	}
}

