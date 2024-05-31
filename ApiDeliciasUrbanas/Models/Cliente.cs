using System.ComponentModel.DataAnnotations;

namespace ApiDeliciasUrbanas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Codigocliente { get; set; }
        [Required]
        public string Nombre1 { get; set; }
        [Required]
        public string Nombre2 { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        [Required]
        public int DNI { get; set; }
        [Required]
        public int Celular{ get; set; }        
    }
}
