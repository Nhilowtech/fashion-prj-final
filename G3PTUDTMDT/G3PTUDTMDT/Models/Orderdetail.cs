using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Orderdetail
	{
        [Key]
        public string MachitietDH { get; set; }
        [Required]
        public int MaDH { get; set; }
        [Required]
        public string MaSP { get; set; }
        [Required]
        public int SL { get; set; }
        [Required]
        public int Gia { get; set; }
        public Orderdetail()
		{
		}
	}
}

