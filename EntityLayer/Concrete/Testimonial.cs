using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Testimonial {
        [Key]
        public int TestimonialID { get; set; }
        public required string ClientName { get; set; }
        public required string Company { get; set; }
        public required string Comment { get; set; }
        public required string Title { get; set; }
        public required string ImageUrl { get; set; }
    }
}
