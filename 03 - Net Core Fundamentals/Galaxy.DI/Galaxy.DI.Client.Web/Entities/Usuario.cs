﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Galaxy.DI.Client.Web.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            ComentarioUsuarioIdActualizacionNavigation = new HashSet<Comentario>();
            ComentarioUsuarioIdCreacionNavigation = new HashSet<Comentario>();
            ComentarioUsuarioIdPropietarioNavigation = new HashSet<Comentario>();
            PostUsuarioIdActualizacionNavigation = new HashSet<Post>();
            PostUsuarioIdCreacionNavigation = new HashSet<Post>();
            PostUsuarioIdPropietarioNavigation = new HashSet<Post>();
        }

        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string MiCampo { get; set; }

        public virtual ICollection<Comentario> ComentarioUsuarioIdActualizacionNavigation { get; set; }
        public virtual ICollection<Comentario> ComentarioUsuarioIdCreacionNavigation { get; set; }
        public virtual ICollection<Comentario> ComentarioUsuarioIdPropietarioNavigation { get; set; }
        public virtual ICollection<Post> PostUsuarioIdActualizacionNavigation { get; set; }
        public virtual ICollection<Post> PostUsuarioIdCreacionNavigation { get; set; }
        public virtual ICollection<Post> PostUsuarioIdPropietarioNavigation { get; set; }
    }
}