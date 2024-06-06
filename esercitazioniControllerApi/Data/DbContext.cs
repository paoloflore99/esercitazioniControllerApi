using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace esercitazioniControllerApi.Data
{
    public class DbContext : IdentityDbContext<IdentityUser>
    {

        public List<Foto> Fotos { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Commenti>? Commenti { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Foto;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
