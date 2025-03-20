using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Service {
        [Key]
        public int ServiceID { get; set; }
        public required string Title { get; set; }
        public required string ImageUrl { get; set; }
    }
}
