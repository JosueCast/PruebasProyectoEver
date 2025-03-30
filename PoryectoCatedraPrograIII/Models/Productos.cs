using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Productos
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int tienda_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal precio { get; set; }

        public int stock { get; set; }

        [StringLength(50)]
        public string categoria { get; set; }

        public string fotografia { get; set; }

        //public string video_review { get; set; }

        [StringLength(50)]
        public string sku { get; set; }

        public string descripcion { get; set; }

        [StringLength(50)]
        public string marca { get; set; }

        [StringLength(20)]
        public string estado { get; set; }

        public DateTime creado_en { get; set; } = DateTime.Now;

        public DateTime actualizado_en { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("tienda_id")]
        public Tiendas tienda { get; set; }

        public ICollection<Resena> resenas { get; set; }
        public ICollection<Promocion> promotiones { get; set; }
        public ICollection<ElementoGuardado> elementos_guardados
        {
            get; set;
        }
    }
}
