using System;

namespace PlataformaEducativa.Models
{
    public class ProgresoCurso
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCurso { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public Usuarios Usuario { get; set; }
        public Cursos Curso { get; set; }
    }
}