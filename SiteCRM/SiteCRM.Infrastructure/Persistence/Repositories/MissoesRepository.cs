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
	public class MissoesRepository : IMissoesRepository
	{
		private readonly SiteCRMDbContext _dbContext;
		private readonly string _connectionString;
        public MissoesRepository(SiteCRMDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
			_connectionString = configuration.GetConnectionString("SiteCRM");
        }

        public async Task AddAsync(Missoes missoes)
		{
			await _dbContext.Missoes.AddAsync(missoes);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(Missoes missoes)
		{
			_dbContext.Remove(missoes);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<Missoes>> GetAllAsync()
		{
			return await _dbContext.Missoes.ToListAsync();
		}

		public async Task<Missoes> GetAsync(int id)
		{
			return await _dbContext.Missoes.FirstOrDefaultAsync(m => m.Id == id);
		}
	}
}
