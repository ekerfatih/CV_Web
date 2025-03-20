using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework {
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal {
        public EfExperienceDal(Context context) : base(context) {
        }
    }
}
