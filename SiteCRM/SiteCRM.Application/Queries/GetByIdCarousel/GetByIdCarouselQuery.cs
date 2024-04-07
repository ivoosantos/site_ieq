using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdCarousel
{
    public class GetByIdCarouselQuery : IRequest<CarouselViewModel>
    {
        public int Id { get; set; }

        public GetByIdCarouselQuery(int id)
        {
            Id = id;
        }
    }
}
