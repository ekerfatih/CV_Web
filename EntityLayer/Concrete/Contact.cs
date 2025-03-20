using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Contact {
        [Key]
        public int ContactID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Mail { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
