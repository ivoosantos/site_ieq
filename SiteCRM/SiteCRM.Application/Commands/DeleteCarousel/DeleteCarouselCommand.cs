using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteCarousel
{
    public class DeleteCarouselCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteCarouselCommand(int id)
        {
            Id = id;
        }
    }
}
