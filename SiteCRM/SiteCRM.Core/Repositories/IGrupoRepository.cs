using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
	public interface IGrupoRepository
	{
		Task AddAsync(Grupo grupo);
		Task<List<Grupo>> GetAllAsync();
		Task<Grupo> GetByIdAsync(int id);
		Task DeleteAsync(Grupo grupo);
	}
}
