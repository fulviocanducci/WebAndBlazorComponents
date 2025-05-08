using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
   public class UsuarioModel
   {
      [Required(ErrorMessage = "O nome � obrigat�rio.")]
      public string? Nome { get; set; }

      [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
      [EmailAddress(ErrorMessage = "O e-mail n�o � v�lido.")]
      public string? Email { get; set; }
   }
}
