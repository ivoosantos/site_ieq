using MediatR;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteSobre
{
	public class DeleteSobreCommandHandler : IRequestHandler<DeleteSobreCommand, Unit>
	{
		private readonly ISobreRepository _sobreRepository;
        public DeleteSobreCommandHandler(ISobreRepository sobreRepository)
        {
            _sobreRepository = sobreRepository;
        }

        public async Task<Unit> Handle(DeleteSobreCommand request, CancellationToken cancellationToken)
		{
			var sobre = await _sobreRepository.GetByIdAsync(request.Id);

			await _sobreRepository.DeleteAsync(sobre);

			return Unit.Value;
		}
	}
}
