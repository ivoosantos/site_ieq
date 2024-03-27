using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Carousel : BaseEntity
    {
        public Carousel(string img, string titulo, string informacao, string end_url, string active_img)
        {
            this.img = img;
            this.titulo = titulo;
            this.informacao = informacao;
            this.end_url = end_url;
            this.active_img = active_img;
        }

        public string img { get; set; }
        public string titulo { get; set; }
        public string informacao { get; set; }
        public string end_url { get; set; }
        public string active_img { get; set; }

        //public Carousel(string _img, string _titulo, string _informacao, string _end_url, string _active_img)
        //{
        //    img = _img;
        //    titulo = _titulo;
        //    informacao = _informacao;
        //    end_url = _end_url;
        //    active_img = _active_img;
        //}
    }
}
