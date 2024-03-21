using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> GetByIdAsync(int id);
        Task<List<Contact>> GetAllAsync();
        Task DeleteAsync(Contact contact);
        Task AddAsync(Contact contact);
        //Task SaveChangesAsync();
    }
}
