using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
    public interface IBlogRepository
    {
        Task AddAsync(Blog blog);
        Task<Blog> GetByIdAsync(int id);
        Task<List<Blog>> GetAllAsync();
        Task DeleteAsync(Blog blog);
    }
}
