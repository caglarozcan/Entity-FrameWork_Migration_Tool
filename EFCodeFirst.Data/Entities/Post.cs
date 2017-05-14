using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Data.Entities
{
	public class Post
	{
		public int ID { get; set; }

		public string Header { get; set; }

		public string Content { get; set; }

		public DateTime CreateAt { get; set; }

		//public string Slug { get; set; }

		public byte Status { get; set; }
	}
}
