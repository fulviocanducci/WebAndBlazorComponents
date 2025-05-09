using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Models
{
   public class UsuarioModel
   {
      [JsonPropertyName("id")]
      public int Id { get; set; }

      [Required(ErrorMessage = "O nome � obrigat�rio.")]
      [JsonPropertyName("nome")]
      public string? Nome { get; set; }

      [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
      [EmailAddress(ErrorMessage = "O e-mail n�o � v�lido.")]
      [JsonPropertyName("email")]
      public string? Email { get; set; }
   }
}
