using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class GrupoViewModel
    {
        public int id { get; set; }
        public string img { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string slug { get; set; }
        public string categoria { get; set; }
        public string nome { get; set; }
        public virtual byte[] imgByte { get; set; }

        public GrupoViewModel(int _id, string _img, string _titulo, string _descricao, string _slug, string _categoria, string _nome)
        {
            this.id = _id;
            this.img = _img;
            this.titulo = _titulo;
            this.descricao = _descricao;
            this.slug = _slug;
            this.categoria = _categoria;
            this.nome = _nome;
        }
    }
}
