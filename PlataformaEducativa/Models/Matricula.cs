using System;

namespace PlataformaEducativa.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCurso { get; set; }
        public DateTime FechaMatricula { get; set; }

        public Usuarios Usuario { get; set; }
        public Cursos Curso { get; set; }
    }
}