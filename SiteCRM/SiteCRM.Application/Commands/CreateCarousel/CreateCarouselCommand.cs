using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateCarousel
{
    public class CreateCarouselCommand : IRequest<int>
    {
        public string titulo { get; set; }
        public string informacao { get; set; }
        public string end_url { get; set; }
        public string img { get; set; }
        public bool active_img { get; set; }
        public virtual IFormFile File { get; set; }
        public int IdIgreja { get; private set; }
    }
}
