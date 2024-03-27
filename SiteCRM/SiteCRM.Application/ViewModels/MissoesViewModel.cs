using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class MissoesViewModel : ImageViewModel
	{
        public int id { get; set; }
        public string titulo { get; set; }
        public string slug { get; set; }
        public string texto { get; set; }
		public string img { get; set; }
        public DateTime dataPost { get; set; } = DateTime.Now.ToUniversalTime();

        public virtual byte[] imgByte { get; set; }

        public MissoesViewModel()
        {
            
        }

		public MissoesViewModel(int id, string titulo, string slug, string texto, string img, DateTime dataPost)
		{
			this.id = id;
			this.titulo = titulo;
			this.slug = slug;
			this.texto = texto;
			this.img = img;
			this.dataPost = dataPost;
		}
	}
}
