using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllSobres
{
    public class GetAllSobresQuery : IRequest<List<SobreViewModel>>
    {
        public GetAllSobresQuery() { }
    }
}
