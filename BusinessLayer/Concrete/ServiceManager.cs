using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class ServiceManager : GenericManager<Service>, IServiceService {
        public ServiceManager(IGenericDal<Service> genericDal) : base(genericDal) {
        }
    }
}
