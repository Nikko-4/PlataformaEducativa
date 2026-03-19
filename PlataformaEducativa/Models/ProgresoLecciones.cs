using System;

namespace PlataformaEducativa.Models
{
    public class ProgresoLeccion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLeccion { get; set; }
        public bool Completada { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }

        public Usuarios Usuario { get; set; }
        public Leccion Leccion { get; set; }
    }
}