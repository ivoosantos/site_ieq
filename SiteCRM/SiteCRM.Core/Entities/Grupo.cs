﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Grupo : BaseEntity
    {
        public Grupo(string img, string titulo, string descricao, string slug, string categoria, string nome, int idIgreja)
        {
            this.img = img;
            this.titulo = titulo;
            this.descricao = descricao;
            this.slug = slug;
            this.categoria = categoria;
            this.nome = nome;
            this.IdIgreja = idIgreja;
        }

        public string img { get; private set; }
        public string titulo { get; private set; }
        public string descricao { get; private set; }
        public string slug { get; private set; }
        public string categoria { get; private set; }
        public string nome { get; private set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }

        public void Update(string img, string titulo, string descricao, string slug, string categoria, string nome)
        {
            this.img = img;
            this.titulo = titulo;
            this.descricao = descricao;
            this.slug = slug;
            this.categoria = categoria;
            this.nome = nome;
        }
    }
}
