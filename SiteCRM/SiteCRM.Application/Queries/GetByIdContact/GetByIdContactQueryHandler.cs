using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdContact
{
    public class GetByIdContactQueryHandler : IRequestHandler<GetByIdContactQuery, ContactViewModel>
    {
        private readonly IContactRepository _contactRepository;

        public GetByIdContactQueryHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ContactViewModel> Handle(GetByIdContactQuery request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);
            
            if (contact == null) 
                return null;

            return new ContactViewModel(contact.Id, contact.nome, contact.telefone, contact.email, contact.email, contact.data, contact.IsPrayer, contact.IdIgreja);
        }
    }
}
