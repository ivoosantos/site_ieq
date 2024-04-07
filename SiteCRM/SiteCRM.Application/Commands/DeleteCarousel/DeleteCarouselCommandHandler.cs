using MediatR;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteCarousel
{
    public class DeleteCarouselCommandHandler : IRequestHandler<DeleteCarouselCommand, Unit>
    {
        private readonly ICarouselRepository _carouselRepository;

        public DeleteCarouselCommandHandler(ICarouselRepository carouselRepository)
        {
            _carouselRepository = carouselRepository;
        }

        public async Task<Unit> Handle(DeleteCarouselCommand request, CancellationToken cancellationToken)
        {
            var carousel = await _carouselRepository.GetByIdAsync(request.Id);
            if (carousel == null) return Unit.Value;

            await _carouselRepository.DeleteAsync(carousel);
            return Unit.Value;
        }
    }
}
