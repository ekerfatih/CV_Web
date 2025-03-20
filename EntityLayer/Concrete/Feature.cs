using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Feature {
        [Key]
        public int FeatureID { get; set; }
        public required string Header { get; set; }
        public required string Name { get; set; }
        public required string Title { get; set; }
    }
}
