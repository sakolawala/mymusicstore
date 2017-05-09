using System.ComponentModel.DataAnnotations;

namespace MyMusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}