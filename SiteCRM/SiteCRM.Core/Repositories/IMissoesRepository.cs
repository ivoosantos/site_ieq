using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
	public interface IMissoesRepository
	{
		Task AddAsync(Missoes missoes);
		Task<Missoes> GetAsync(int id);
		Task<List<Missoes>> GetAllAsync();
		Task DeleteAsync(Missoes missoes);
	}
}
