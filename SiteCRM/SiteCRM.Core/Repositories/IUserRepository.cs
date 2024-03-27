﻿using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Repositories
{
	public interface IUserRepository
	{
		Task<User> GetByIdAsync(int id);
		Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
	}
}
