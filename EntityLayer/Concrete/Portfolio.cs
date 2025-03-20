using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Portfolio {
        [Key]
        public int PortfolioID { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required string ImageUrl2 { get; set; }
        public required string ProjectUrl { get; set; }
    }
}
