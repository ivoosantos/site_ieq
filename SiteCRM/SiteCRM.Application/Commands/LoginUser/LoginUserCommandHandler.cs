using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using SiteCRM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.LoginUser
{
	public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
	{
		private readonly IAuthService _authService;
		private readonly IUserRepository _userRepository;
        public LoginUserCommandHandler(IAuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
			_userRepository = userRepository;
        }
        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
		{
			var passwordHash = _authService.ComputeSha256Hash(request.Password);

			var user = await _userRepository.GetUserByEmailAndPasswordAsync(request.Email, passwordHash);

            if (user == null)
            {
                return null;
            }

            var token = _authService.GenerateJwtToken(user.user_email, user.user_senha);

            return new LoginUserViewModel(user.user_email, token);
        }
	}
}
