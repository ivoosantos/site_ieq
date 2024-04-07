using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
    public interface ICarouselRepository
    {
        Task AddAsync(Carousel carousel);
        Task<Carousel> GetByIdAsync(int id);
        Task<List<Carousel>> GetAllAsync();
        Task DeleteAsync(Carousel contact);
    }
}
