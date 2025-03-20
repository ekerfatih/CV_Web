using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class PortfolioManager : GenericManager<Portfolio>, IPortfolioService {
        public PortfolioManager(IGenericDal<Portfolio> genericDal) : base(genericDal) {
        }
    }
}
