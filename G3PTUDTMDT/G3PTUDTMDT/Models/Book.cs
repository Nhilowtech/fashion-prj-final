using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
    public class Book
    {
        [Key]
        public string MaSP { get; set; }
        [Required]
        public string TenSP { get; set; }
        [Required]
        public string AnhSP { get; set; }
        [Required]
        public string ChitietSP { get; set; }
        [Required]
        public string Tacgia { get; set; }
        [Required]
        public int Soluong { get; set; }
        [Required]
        public int SLmua { get; set; }
        [Required]
        public float Gia { get; set; }

        public Book()
        {
            // Khởi tạo đối tượng Book
        }
    }
}


