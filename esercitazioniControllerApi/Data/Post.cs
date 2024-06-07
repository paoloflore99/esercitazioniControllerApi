using System.ComponentModel.DataAnnotations;
namespace esercitazioniControllerApi.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int? Commentid { get; set; }
        public Commenti? Commenti { get; set; }

        public int? LikeId { get; set; }
        public Like? Like { get; set; }

        public int? TagId { get; set; }
        public Tag? Tag { get; set; }

        public int FotoId { get; set; }
        public Foto Foto { get; set; }
    }
}
