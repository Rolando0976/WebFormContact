using System.ComponentModel.DataAnnotations;

namespace WebFormContact.Models
{
    public class ContactMesseges

    {
        public int Id { get; set; }

        [Required(ErrorMessage = " El nombre esobligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = " El nombre esobligatorio")]
        [EmailAddress(ErrorMessage ="El correo electronico es obligatorio")]
        [StringLength(75, ErrorMessage ="El correo no puede exeder los 75 caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="El mensaje es obligatorio")]
        [StringLength(150, ErrorMessage = "El mensaje no puede exceder los 150 caracteres")]
        public string Mensaje { get; set; }
    }
}
