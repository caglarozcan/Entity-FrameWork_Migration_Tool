﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Data.Entities
{
	public class User
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime CreateAt { get; set; }

		public byte Status { get; set; }
	}
}
