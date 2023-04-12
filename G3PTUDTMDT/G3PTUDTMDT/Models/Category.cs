using System;
using System.ComponentModel.DataAnnotations;

namespace G3PTUDTMDT.Models
{
	public class Category
	{
        [Key]
        public int MaDM { get; set; }
        [Required]
        public string TenDM { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public int MaDM_parent { get; set; }
        [Required]
        public string Created_by { get; set; } = "default value";
        [Required]
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
        public Category()
		{
		}
	}
}

