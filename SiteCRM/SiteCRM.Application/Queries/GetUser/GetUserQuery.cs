using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetUser
{
	public class GetUserQuery : IRequest<UserViewModel>
	{
		public GetUserQuery(int id)
		{
			Id = id;
		}

		public int Id { get; private set; }
    }
}
