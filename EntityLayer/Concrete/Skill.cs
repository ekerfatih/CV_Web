using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete {
    public class Skill {
        [Key]
        public int SkillID { get; set; }
        public required string Title { get; set; }
        public required string Value { get; set; }
    }
}
