using System.ComponentModel.DataAnnotations;

namespace ApiDeliciasUrbanas.Models
{
    public class Local
    {
        public int Id { get; set; }
        [Required]
        public string LocalCodigo { get; set; }
        [Required]
        public string LocalDescripcion { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Departament { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Distrito { get; set; }
    }
}
