using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Missoes : BaseEntity
    {
        public Missoes(string titulo, string slug, string texto, string img, DateTime dataPost)
        {
            this.titulo = titulo;
            this.slug = slug;
            this.texto = texto;
            this.img = img;
            this.dataPost = dataPost;
        }

        public string titulo { get; set; }
        public string slug { get; set; }
        public string texto { get; set; }
        public string img { get; set; }
        public DateTime dataPost { get; set; }

        //public Missoes(string titulo_, string slug_, string texto_, string img_, DateTime dataPost_)
        //{
        //    this.titulo = titulo_;
        //    this.slug = slug_;
        //    this.texto = texto_;
        //    this.img = img_;
        //    this.dataPost = dataPost_;
        //}
    }
}
