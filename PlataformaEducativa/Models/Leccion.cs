using System.ComponentModel.DataAnnotations.Schema;
namespace PlataformaEducativa.Models { [Table("lecciones")] 
public class Leccion { public int Id { get; set; } [Column("id_curso")]
        public int IdCurso { get; set; } 
        public string Titulo { get; set; } 
        public string Contenido { get; set; }
        public int? Orden { get; set; } [Column("video_url")] 
        public string VideoUrl { get; set; } [ForeignKey("IdCurso")] 
        public Cursos Curso { get; set; } } }