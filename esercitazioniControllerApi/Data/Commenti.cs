using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace esercitazioniControllerApi.Data
{
    public class Commenti
    {
        public int Id { get; set; } 
        public string Commento { get; set; }
        public List<Post> Posts { get; set; }
        public Commenti() { }
    }
} 
