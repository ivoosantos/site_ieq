using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
    public interface ISobreRepository
    {
        Task<List<Sobre>> GetAllAsync();
        Task AddAsync(Sobre sobre);
    }
}
