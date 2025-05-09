using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
   public class Db: DbContext
   {
      public Db(DbContextOptions<Db> options) : base(options)
      {
      }
      public DbSet<UsuarioModel> Usuarios { get; set; }
      
   }
}
