using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Servicios
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int tienda_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string categoria { get; set; }

        public string descripcion { get; set; }

        public string materiales_Utilizados { get; set; }

        public string tiempo_estimado { get; set; }

        public string ubicacion_servicio { get; set; }

        public DateTime creado_en { get; set; } = DateTime.Now;

        public DateTime actualizado_en { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("tienda_id")]
        public Tiendas tienda { get; set; }
    }
}
