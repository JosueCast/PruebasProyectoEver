using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Resena
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int TiendaId { get; set; }

        public string Comentario { get; set; }

        [Required]
        [Range(1, 5)]
        public int Califcxom { get; set; }

        public DateTime CreadoEn { get; set; } = DateTime.Now;

        public DateTime ActualizadoEn { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("ProductoId")]
        public Productos Producto { get; set; }

        [ForeignKey("TiendaId")]
        public Tiendas Tienda { get; set; }

    }
}
