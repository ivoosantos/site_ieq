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
    public class BlogRepository : IBlogRepository
    {
        private readonly SiteCRMDbContext _dbContext;
        private readonly string _connectionString;
        public BlogRepository(SiteCRMDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("SiteCRM");
        }

        public async Task AddAsync(Blog blog)
        {
            await _dbContext.Blogs.AddAsync(blog);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Blog blog)
        {
            _dbContext.Remove(blog);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Blog>> GetAllAsync()
        {
            return await _dbContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _dbContext.Blogs.FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
