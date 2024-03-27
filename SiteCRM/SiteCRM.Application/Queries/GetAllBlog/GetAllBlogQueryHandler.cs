using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllBlog
{
    public class GetAllBlogQueryHandler : IRequestHandler<GetAllBlogQuery, List<BlogViewModel>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetAllBlogQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<BlogViewModel>> Handle(GetAllBlogQuery request, CancellationToken cancellationToken)
        {
            var listBlog = await _blogRepository.GetAllAsync();

            return listBlog
                .Select(b => new BlogViewModel(b.Id, b.titulo, b.slug, b.texto, b.img))
                .ToList();
        }
    }
}
