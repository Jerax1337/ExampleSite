using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example.Storage.Models;

namespace Example.Storage.Database
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions option) : base (option)
		{

		}

		public virtual DbSet<Center> Centers { get; set; }

		public virtual DbSet<User> Users { get; set; }
	}
}
