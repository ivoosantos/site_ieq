using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.LoginUser
{
	public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
	{
		public Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
