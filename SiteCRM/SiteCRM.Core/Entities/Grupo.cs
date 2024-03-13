using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Grupo : BaseEntity
    {
        public Grupo(string img, string titulo, string descricao, string slug, string categoria, string nome)
        {
            this.img = img;
            this.titulo = titulo;
            this.descricao = descricao;
            this.slug = slug;
            this.categoria = categoria;
            this.nome = nome;
        }

        public string img { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string slug { get; set; }
        public string categoria { get; set; }
        public string nome { get; set; }

        //public Grupo(string _img, string _titulo, string _descricao, string _slug, string _categoria, string _nome)
        //{
        //    this.img = _img;
        //    this.titulo = _titulo;
        //    this.descricao = _descricao;
        //    this.slug = _slug;
        //    this.categoria = _categoria;
        //    this.nome = _nome;
        //}
    }
}
