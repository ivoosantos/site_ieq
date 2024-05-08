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
    public class CarouselRepository : ICarouselRepository
    {
        private readonly SiteCRMDbContext _dbcontext;
        private readonly string _connectionString;
        public CarouselRepository(SiteCRMDbContext dbcontext, IConfiguration configuration)
        {
            _dbcontext = dbcontext;
            _connectionString = configuration.GetConnectionString("SiteCRM");
        }
        public async Task AddAsync(Carousel carousel)
        {
            await _dbcontext.Carousels.AddAsync(carousel);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Carousel contact)
        {
            _dbcontext.Remove<Carousel>(contact);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Carousel>> GetAllAsync()
        {
            return await _dbcontext.Carousels.ToListAsync();
        }

        public async Task<Carousel> GetByIdAsync(int id)
        {
            return await _dbcontext.Carousels.FirstOrDefaultAsync(c => c.Id == id);//.FindAsync(id);
        }
    }
}
