using System.ComponentModel.DataAnnotations;

namespace esercitazioniControllerApi.Data
{
    public class Foto
    {
        [Key]
        public int Id { get; set; }
        //public byte[] Name { get; set; }
        public List<Post> Posts { get; set; }
        public Foto() { }
    }
}
