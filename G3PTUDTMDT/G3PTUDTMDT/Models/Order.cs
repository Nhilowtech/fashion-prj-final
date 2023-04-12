using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Order
	{
        [Key]
        public string MaDH { get; set; }
        [Required]
        public string Mavandon { get; set; }
        [Required]
        public string MaKH { get; set; }
        [Required]
        public DateTime Ngaydatdon { get; set; }
        [Required]
        public string Hoten { get; set; }
        [Required]
        public int SDT { get; set; }
        [Required]
        public int Province { get; set; }
        [Required]
        public int District { get; set; }
        [Required]
        public string Diachi { get; set; }
        public Order()
		{
		}
	}
}

