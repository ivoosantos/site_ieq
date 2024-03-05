using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class MissoesViewModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string slug { get; set; }
        public string texto { get; set; }
        public string img { get; set; }
        public DateTime dataPost { get; set; }

        public MissoesViewModel(int id_, string titulo_, string slug_, string texto_, string img_, DateTime dataPost_)
        {
            this.id = id_;
            this.titulo = titulo_;
            this.slug = slug_;
            this.texto = texto_;
            this.img = img_;
            this.dataPost = dataPost_;
        }
    }
}
