using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class CarouselViewModel
    {
        public int id { get; set; }
        public string img { get; set; }
        public string titulo { get; set; }
        public string informacao { get; set; }
        public string end_url { get; set; }
        public string active_img { get; set; }

        public CarouselViewModel(int id_, string img_, string titulo_, string informacao_, string end_url_, string active_img_)
        {
            this.id = id_;
            this.img = img_;
            this.titulo = titulo_;
            this.informacao = informacao_;
            this.end_url = end_url_;
            this.active_img = active_img_;
        }
    }
}
