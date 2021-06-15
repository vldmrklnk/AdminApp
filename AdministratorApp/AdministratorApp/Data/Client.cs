﻿using System;
using System.Linq;

namespace Data
{
	public class Client
	{
		public int ClientId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string? Address { get; set; }
		public string Phone { get; set; }
		public string? Email { get; set; }

		public virtual IQueryable<Car> Cars { get; set; }
	}
}
