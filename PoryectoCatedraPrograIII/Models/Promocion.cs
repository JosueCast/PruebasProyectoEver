using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Promocion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TiendaId { get; set; }

        public int? ProductoId { get; set; }

        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Descuento { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFn { get; set; }

        public DateTime CreadoEn { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("TiendaId")]
        public Tiendas Tienda { get; set; }

        [ForeignKey("ProductoId")]
        public Productos Producto { get; set; }
    }

}
