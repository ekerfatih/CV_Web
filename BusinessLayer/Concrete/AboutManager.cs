using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class AboutManager : GenericManager<About>, IAboutService {

        public AboutManager(IAboutDal aboutDal) : base(aboutDal) {
        }
    }
}
