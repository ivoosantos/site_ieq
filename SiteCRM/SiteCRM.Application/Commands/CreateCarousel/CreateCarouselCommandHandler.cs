using MediatR;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateCarousel
{
    public class CreateCarouselCommandHandler : IRequestHandler<CreateCarouselCommand, int>
    {
        private readonly ICarouselRepository _carouselRepository;

        public CreateCarouselCommandHandler(ICarouselRepository carouselRepository)
        {
            _carouselRepository = carouselRepository;
        }

        public async Task<int> Handle(CreateCarouselCommand request, CancellationToken cancellationToken)
        {
            var filePath = Path.Combine("Storage", request.File.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            request.File.CopyTo(fileStream);
            fileStream.FlushAsync().Wait();

            var carousel = new Carousel(filePath, request.titulo, request.informacao, request.end_url, request.active_img, request.IdIgreja);

            await _carouselRepository.AddAsync(carousel);
            return carousel.Id;
        }
    }
}
