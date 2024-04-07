using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteBlog
{
    public class DeleteBlogCommand : IRequest<Unit>
    {
        public int Id { get; private set; }

        public DeleteBlogCommand(int id)
        {
            Id = id;
        }
    }
}
