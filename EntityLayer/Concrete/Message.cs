using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Message {
        [Key]
        public int MessageID { get; set; }
        public required string Name { get; set; }
        public required string Mail { get; set; }
        public required string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
