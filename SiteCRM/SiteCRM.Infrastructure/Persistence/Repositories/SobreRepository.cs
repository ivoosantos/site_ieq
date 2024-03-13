using Dapper;
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
    public class SobreRepository : ISobreRepository
    {
        private readonly SiteCRMDbContext _dbContext;
        private readonly string _connectionString;
        public SobreRepository(SiteCRMDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("SiteCRM");
        }

        public async Task AddAsync(Sobre sobre)
        {
            await _dbContext.Sobres.AddAsync(sobre);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Sobre>> GetAllAsync() => await _dbContext.Sobres.ToListAsync();
    }
}
