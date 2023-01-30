using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Library
{
	public class ContactDal
	{
		public List<Contact> GetByName(string key)
		{
			using (DbContactContext context = new DbContactContext())
			{
				var result = context.Contacts.Where(x => (x.Name + " " + x.Surname).Contains(key)).ToList();
				return result;
			}
		}

		public List<Contact> GetAll()
		{
			using(DbContactContext context= new DbContactContext())
			{
				var result = context.Contacts.ToList();
				return result;
			}
		}

		public void Add(Contact contact)
		{
			using (DbContactContext context = new DbContactContext())
			{
				var entity = context.Entry(contact);
				entity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Update(Contact contact)
		{
			using (DbContactContext context = new DbContactContext())
			{
				var entity = context.Entry(contact);
				entity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(Contact contact)
		{
			using (DbContactContext context = new DbContactContext())
			{
				var entity = context.Entry(contact);
				entity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}
	}
}
