using System;
using Microsoft.EntityFrameworkCore;

namespace G3PTUDTMDT.Models
{
	public class Bookdbcontext : DbContext
	{
		public Bookdbcontext(DbContextOptions<Bookdbcontext> options): base(options)
		{
		}
        public DbSet<Book> Book { get; set; }
		public DbSet<Category> Category { get; set; }
    }
}

