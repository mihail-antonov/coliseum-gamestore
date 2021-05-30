namespace Models
{
    using System.ComponentModel.DataAnnotations;

    public class GameDetail
    {
        [Required]
        public int GameId { get; set; }

        [Required]
        public int DetailId { get; set; }

        public Game Game { get; set; }
        public Detail Detail { get; set; }
    }
}
