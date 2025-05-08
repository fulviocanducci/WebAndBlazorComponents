using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
   public class UsuarioModel
   {
      [Required(ErrorMessage = "O nome é obrigatório.")]
      public string? Nome { get; set; }

      [Required(ErrorMessage = "O e-mail é obrigatório.")]
      [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
      public string? Email { get; set; }
   }
}
