using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework {
    public class EfPortfolioDal : GenericRepository<Portfolio>, IPortfolioDal {
        public EfPortfolioDal(Context context) : base(context) {
        }
    }
}
