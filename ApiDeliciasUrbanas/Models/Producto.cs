using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiDeliciasUrbanas.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string ProductoCodigo { get; set; }
        [Required]
        public string ProductoDescripcion { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string Almacen { get; set; }
        [Precision(18,2)]         
        public decimal PrecioUnitaio { get; set; }        
        public int Stock { get; set; }
    }
}
