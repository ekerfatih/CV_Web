using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework {
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal {
        public EfSkillDal(Context context) : base(context) {
        }
    }
}
