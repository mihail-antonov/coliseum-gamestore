namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Released { get; set; }

        [ForeignKey("Studio")]
        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        public ICollection<GameDetail> GameDetails { get; set; }
    }
}
