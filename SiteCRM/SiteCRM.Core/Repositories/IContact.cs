using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
    public interface IContact
    {
        Task<Contact> GetAsync();
        Task<Contact> GetByIdAsync(int id);
        Task<List<Contact>> GetAllAsync();
        Task DeleteAsync(int id);
        Task AddAsync(Contact contact);
        Task SaveChangesAsync();
    }
}
