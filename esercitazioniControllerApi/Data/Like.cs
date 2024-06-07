using System.ComponentModel.DataAnnotations;
using MessagePack;
namespace esercitazioniControllerApi.Data
{
    public class Like
    {
        public int Id { get; set; }
        public bool SiNo { get; set; }
        public List<Post> Posts { get; set; }
        public Like() { }
    }
}
