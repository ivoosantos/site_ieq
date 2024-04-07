using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllContact
{
    public class GetAllContactQueryHandler : IRequestHandler<GetAllContactQuery, List<ContactViewModel>>
    {
        private readonly IContactRepository _contactRepository;

        public GetAllContactQueryHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<List<ContactViewModel>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            var findAll = await _contactRepository.GetAllAsync();

            var listContacts = findAll
                .Select(c => new ContactViewModel(c.Id, c.nome, c.telefone, c.email, c.mensagem, c.data, c.IsPrayer, c.IdIgreja))
                .ToList();

            return listContacts;
        }
    }
}
