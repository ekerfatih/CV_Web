using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class About {
        [Key]
        public int AboutID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Age { get; set; }
        public required string Mail { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required string ImageUrl { get; set; }
    }
}
