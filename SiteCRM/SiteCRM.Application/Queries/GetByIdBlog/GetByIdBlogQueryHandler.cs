using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdBlog
{
    public class GetByIdBlogQueryHandler : IRequestHandler<GetByIdBlogQuery, BlogViewModel>
    {
        private readonly IBlogRepository _blogRepository;

        public GetByIdBlogQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogViewModel> Handle(GetByIdBlogQuery request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdAsync(request.Id);

            if (blog == null) return null;

            return new BlogViewModel(blog.Id, blog.titulo, blog.slug, blog.texto, blog.img);
        }
    }
}
