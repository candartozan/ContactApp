using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Library
{
	internal class DbContactContext : DbContext
	{
		public DbSet<Contact> Contacts { get; set; }

		public DbContactContext():base("server=BamGumToshiba;initial catalog=DbContact;integrated security=true")
		{

		}
	}
}
