using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllCarousel
{
    public class GetAllCarouselQueryHandler : IRequestHandler<GetAllCarouselQuery, List<CarouselViewModel>>
    {
        private readonly ICarouselRepository _carouselRepository;

        public GetAllCarouselQueryHandler(ICarouselRepository carouselRepository)
        {
            _carouselRepository = carouselRepository;
        }

        public async Task<List<CarouselViewModel>> Handle(GetAllCarouselQuery request, CancellationToken cancellationToken)
        {
            var listCarousel = await _carouselRepository.GetAllAsync();

            var carousels = listCarousel
                .Select(c => new CarouselViewModel(c.Id, c.img, c.titulo, c.informacao, c.end_url, c.active_img, c.IdIgreja))
                .ToList();
            return carousels;
        }
    }
}
