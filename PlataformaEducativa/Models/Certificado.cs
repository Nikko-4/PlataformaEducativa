using System;

namespace PlataformaEducativa.Models
{
    public class Certificado
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCurso { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Codigo { get; set; }

        public Usuarios Usuario { get; set; }
        public Cursos Curso { get; set; }
    }
}