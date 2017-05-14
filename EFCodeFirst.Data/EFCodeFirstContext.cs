using EFCodeFirst.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Data
{
	public class EFCodeFirstContext : DbContext
	{
		public EFCodeFirstContext()
		{
			Database.Connection.ConnectionString = "Data Source=DESKTOP-AAT4IFT\\SQLSERVER;Initial Catalog=EFCodeFirst;Persist Security Info=True;User ID=sa;Password=123456";
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<User> User { get; set; }

		public DbSet<Post> Post { get; set; }
	}
}
