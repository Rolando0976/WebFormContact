using System.ComponentModel.DataAnnotations;

namespace WebFormContact.Models
{
    public class ContactMessage

    {
        public int Id { get; set; }

        [Required(ErrorMessage = " El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage ="Formato de correo no válido")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="El mensaje es obligatorio")]
        [StringLength(500, ErrorMessage = "El mensaje no puede exceder los 500 caracteres")]
        public string Mensaje { get; set; }
    }
}
