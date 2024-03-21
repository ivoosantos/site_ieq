using Microsoft.EntityFrameworkCore;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Infrastructure.Persistence.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly SiteCRMDbContext _dbContext;
        public UserRepository(SiteCRMDbContext dbContext)
        {
            _dbContext = dbContext;
		}

		public async Task<User> GetByIdAsync(int id)
		{
			return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
		}
		
		public async Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
		{
			return await _dbContext
				.Users
				.SingleOrDefaultAsync(u => u.user_email == email && u.user_senha == passwordHash);
		}
	}
}
