using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdContact
{
    public class GetByIdContactQuery : IRequest<ContactViewModel>
    {
        public int Id { get; set; }

        public GetByIdContactQuery(int id)
        {
            Id = id;
        }
    }
}
