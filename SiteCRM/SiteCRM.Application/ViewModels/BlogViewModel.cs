using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class BlogViewModel : ImageViewModel
    {
        public BlogViewModel(int id, string titulo, string slug, string texto, string img)
        {
            this.id = id;
            this.titulo = titulo;
            this.slug = slug;
            this.texto = texto;
            this.img = img;
            this.dataPost = DateTime.Now.ToUniversalTime();
        }

        public int id { get; set; }
        public string titulo { get; set; }
        public string slug { get; set; }
        public string texto { get; set; }
        public string img { get; set; }
        public DateTime dataPost { get; set; }

        public virtual byte[] imgByte { get; set; }
    }
}
