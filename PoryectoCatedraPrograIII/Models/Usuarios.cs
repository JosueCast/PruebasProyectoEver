using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuarios { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Contrasena { get; set; }
        public string FotoPerfil { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.Now;
        public DateTime ActualizadoEn { get; set; } = DateTime.Now;
        public ICollection<Tiendas> Tiendas { get; set; }
        public ICollection<Resena> Resenas { get; set; }
        public ICollection<ElementoGuardado> ElementosGuardados { get; set; }
    }
}
