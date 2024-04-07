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
	public class GrupoRepository : IGrupoRepository
	{
		private readonly SiteCRMDbContext _dbcontext;
		private readonly string _connectionString;
        public GrupoRepository(SiteCRMDbContext dbcontext, IConfiguration configuration)
        {
            _dbcontext = dbcontext;
			_connectionString = configuration.GetConnectionString("SiteCRM");
        }

        public async Task AddAsync(Grupo grupo)
		{
			await _dbcontext.Grupos.AddAsync(grupo);
			await _dbcontext.SaveChangesAsync();
		}

		public async Task DeleteAsync(Grupo grupo)
		{
			_dbcontext.Remove(grupo);
			await _dbcontext.SaveChangesAsync();
		}

		public async Task<List<Grupo>> GetAllAsync()
		{
			return await _dbcontext.Grupos.ToListAsync();
		}

		public async Task<Grupo> GetByIdAsync(int id)
		{
			return await _dbcontext.Grupos.FirstOrDefaultAsync(g => g.Id == id);
		}
	}
}
