using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Admin
	{
        [Key]
        public string MaNV { get; set; }
        [Required]
        public string TenNV { get; set; }
        [Required]
        public string Tendangnhap { get; set; }
        [Required]
        public string Matkhau { get; set; }

        public Admin()
		{

		}
	}
}

