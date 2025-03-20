

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework {
    public class EfServiceDal : GenericRepository<Service>, IServiceDal {
        public EfServiceDal(Context context) : base(context) {
        }
    }
}
