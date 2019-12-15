using System.ComponentModel.DataAnnotations;

namespace UrlShortener.Models
{
    public class ShortUrl
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string OriginalUrl { get; set; }
    }
}
