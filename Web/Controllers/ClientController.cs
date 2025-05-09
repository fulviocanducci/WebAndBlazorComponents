using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ClientController : ControllerBase
   {
      private readonly Db db;

      public ClientController(Db db)
      {
         this.db = db;
      }

      [HttpGet]
      public IActionResult Get()
      {
         var usuarios = db.Usuarios.ToList();
         return Ok(usuarios);
      }

      [HttpPost]
      public IActionResult Post([FromBody] UsuarioModel value)
      {
         db.Usuarios.Add(value);
         db.SaveChanges();
         return Ok(new { message = "Value received successfully", receivedValue = value });
      }
   }
}
