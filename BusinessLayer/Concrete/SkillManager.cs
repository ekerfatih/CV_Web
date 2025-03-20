using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class SkillManager : GenericManager<Skill>, ISkillService {
        public SkillManager(IGenericDal<Skill> genericDal) : base(genericDal) {
        }
    }
}
