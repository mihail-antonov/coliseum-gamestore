namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Studio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Founded { get; set; }

        public string Resume { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
