using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Experience {
        [Key]
        public int ExperienceID { get; set; }
        public required string Name { get; set; }
        public required string Date { get; set; }
        public required string ImageURL { get; set; }
        public required string Description { get; set; }
    }
}
