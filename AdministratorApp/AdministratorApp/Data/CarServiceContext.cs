using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class CarServiceContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Order> Orders { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-MBD1D44;Database=AdministratorApp;Trusted_Connection=True;");
		}
	}
}
