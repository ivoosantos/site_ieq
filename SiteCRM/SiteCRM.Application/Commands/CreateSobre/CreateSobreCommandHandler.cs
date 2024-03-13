using MediatR;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateSobre
{
    public class CreateSobreCommandHandler : IRequestHandler<CreateSobreCommand, int>
    {
        private readonly ISobreRepository _sobreRepository;
        public CreateSobreCommandHandler(ISobreRepository sobreRepository)
        {
            _sobreRepository = sobreRepository;
        }

        public async Task<int> Handle(CreateSobreCommand request, CancellationToken cancellationToken)
        {
            var sobre = new Sobre(request.titulo, request.descricao, request.tipo);

            await _sobreRepository.AddAsync(sobre);

            return sobre.Id;
        }
    }
}
