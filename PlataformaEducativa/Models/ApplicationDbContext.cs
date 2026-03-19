using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Web.Services.Description;

namespace PlataformaEducativa.Models
{
    
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Leccion> Lecciones { get; set; }
        public DbSet<ProgresoLeccion> ProgresoLecciones { get; set; }
        public DbSet<ProgresoCurso> ProgresoCursos { get; set; }
        public DbSet<Certificado> Certificados { get; set; }
    }
}