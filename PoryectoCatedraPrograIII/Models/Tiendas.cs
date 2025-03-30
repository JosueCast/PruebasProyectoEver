using System.ComponentModel.DataAnnotations;
using PoryectoCatedraPrograIII.Models;

namespace PoryectoCatedraPrograIII.Models
{
    public class Tiendas
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int usuario_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre_negocio { get; set; }

        [StringLength(50)]
        public string categoria { get; set; }

        public string horario { get; set; }

        public string foto_fachada { get; set; }

        public string slogan { get; set; }

        public string numero_contacto { get; set; }

        public string facebook_url { get; set; }

        public string pagina_web { get; set; }

        public bool cuenta_envio { get; set; }

        public string ubicacion { get; set; }

        public DateTime creado_en { get; set; } = DateTime.Now;

        public DateTime actualizado_en { get; set; } = DateTime.Now;

        // Relaciones
        public ICollection<Productos> productos { get; set; }
        public ICollection<Promocion> promotiones { get; set; }
        public ICollection<Resena> resenas { get; set; }
        public ICollection<Tiendas> sendas { get; set; }

    }
}
