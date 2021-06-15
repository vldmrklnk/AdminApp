using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Car
	{
		public int CarId { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public DateTime Year { get; set; }
		public string VIN { get; set; }

		public virtual IQueryable<Order> Orders { get; set; }

	}
}
