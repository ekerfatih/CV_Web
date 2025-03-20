using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class ExperienceManager : GenericManager<Experience>, IExperienceService {
        public ExperienceManager(IExperienceDal genericDal) : base(genericDal) {
        }
    }
}
