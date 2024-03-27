using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdBlog
{
    public class GetByIdBlogQuery : IRequest<BlogViewModel>
    {
        public int Id { get; private set; }

        public GetByIdBlogQuery(int id)
        {
            Id = id;
        }
    }
}
