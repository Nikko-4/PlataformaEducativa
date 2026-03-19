using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEducativa.Models
{
    public class Cursos
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Nivel { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Publicado { get; set; }

        public int? CreadoPor { get; set; }

        [ForeignKey("CreadoPor")]
        public Usuarios Usuario { get; set; }

        
        public virtual ICollection<Leccion> Lecciones { get; set; }
    }
}