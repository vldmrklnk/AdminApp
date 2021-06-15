using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime DateOfCreation { get; set; }
		public int AmountOfOrder { get; set; }
		public OrderStatus? OrderStatus { get; set; }
	}
	public enum OrderStatus
	{
		Completed,
		InProgress,
		Cancelled
	}
}
