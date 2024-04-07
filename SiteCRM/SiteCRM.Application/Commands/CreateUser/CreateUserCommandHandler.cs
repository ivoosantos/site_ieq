using MediatR;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Services;
using SiteCRM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateUser
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
	{
		private readonly SiteCRMDbContext _dbContext;
		private readonly IAuthService _authService;
        public CreateUserCommandHandler(SiteCRMDbContext dbContext, IAuthService authService)
        {
            _dbContext = dbContext;
			_authService = authService;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			var passaword = _authService.ComputeSha256Hash(request.user_senha);

			var user = new User(request.user_email, request.user_nome, passaword, request.user_tipo, request.idIgreja);

			await _dbContext.Users.AddAsync(user);
			await _dbContext.SaveChangesAsync();

			return Unit.Value;
		}
	}
}
