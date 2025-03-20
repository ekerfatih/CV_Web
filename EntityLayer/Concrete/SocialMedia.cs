using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class SocialMedia {
        [Key]
        public int SocialMediaID { get; set; }
        public required string Name { get; set; }
        public required string Url { get; set; }
        public required string Icon { get; set; }
        public required string Status { get; set; }
    }
}
