using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Infrastructure.Persistence.Repositories
{
	public class ContactRepository : IContactRepository
	{
		private readonly SiteCRMDbContext _dbcontext;
		private readonly string _connectionString;
		public ContactRepository(SiteCRMDbContext dbcontext, IConfiguration configuration)
		{
			_dbcontext = dbcontext;
			_connectionString = configuration.GetConnectionString("SiteCRM");
		}

		public async Task AddAsync(Contact contact)
		{
			await _dbcontext.Contacts.AddAsync(contact);
			await _dbcontext.SaveChangesAsync();
		}

		public async Task DeleteAsync(Contact contact)
		{
			_dbcontext.Remove<Contact>(contact);
			await _dbcontext.SaveChangesAsync();
		}

		public async Task<List<Contact>> GetAllAsync()
		{
			return await _dbcontext.Contacts.ToListAsync();
		}

		public async Task<Contact> GetByIdAsync(int id)
		{
			return await _dbcontext.Contacts.FindAsync(id);
		}
	}
}
