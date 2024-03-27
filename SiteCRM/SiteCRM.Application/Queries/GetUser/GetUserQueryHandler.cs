using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetUser
{
	public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
	{
		private readonly IUserRepository _userRepository;

		public GetUserQueryHandler(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
		{
			var user = await _userRepository.GetByIdAsync(request.Id);

			if (user == null) return null;

			return new UserViewModel(user.Id, user.user_email, user.user_nome, user.user_tipo);
		}
	}
}
