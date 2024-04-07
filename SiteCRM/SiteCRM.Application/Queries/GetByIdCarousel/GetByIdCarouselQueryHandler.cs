using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdCarousel
{
    public class GetByIdCarouselQueryHandler : IRequestHandler<GetByIdCarouselQuery, CarouselViewModel>
    {
        private readonly ICarouselRepository _carouselRepository;

        public GetByIdCarouselQueryHandler(ICarouselRepository carouselRepository)
        {
            _carouselRepository = carouselRepository;
        }

        public async Task<CarouselViewModel> Handle(GetByIdCarouselQuery request, CancellationToken cancellationToken)
        {
            var find = await _carouselRepository.GetByIdAsync(request.Id);

            if (find == null) return null;

            return new CarouselViewModel(find.Id, find.img, find.titulo, find.informacao, find.end_url, find.active_img, find.IdIgreja);
        }
    }
}
