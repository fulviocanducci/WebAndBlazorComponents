using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Models
{
   public class UsuarioModel
   {
      [JsonPropertyName("id")]
      public int Id { get; set; }

      [Required(ErrorMessage = "O nome é obrigatório.")]
      [JsonPropertyName("nome")]
      public string? Nome { get; set; }

      [Required(ErrorMessage = "O e-mail é obrigatório.")]
      [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
      [JsonPropertyName("email")]
      public string? Email { get; set; }
   }
}
