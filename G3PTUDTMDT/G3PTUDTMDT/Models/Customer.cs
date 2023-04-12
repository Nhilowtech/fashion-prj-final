using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Customer
	{
        [Key]
        public string MaKH { get; set; }
        [Required]
        public string TenKH { get; set; }
        [Required]
        public string Tendangnhap { get; set; }
        [Required]
        public string Matkhau { get; set; }
        [Required]
        public string Diachi { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Ngaytao { get; set; }
        public Customer()
		{
		}
	}
}

