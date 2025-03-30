using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class ElementoGuardado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int TiendaId { get; set; }

        public DateTime CreadoEn { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("ProductoId")]
        public Productos Producto { get; set; }

        [ForeignKey("TiendaId")]
        public Tiendas Tienda { get; set; }
    }
}
