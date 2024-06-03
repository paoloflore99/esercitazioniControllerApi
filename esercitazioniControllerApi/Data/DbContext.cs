using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace esercitazioniControllerApi.Data
{
    public class DbContext : IdentityDbContext<IdentityUser>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Foto;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
