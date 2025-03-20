using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework {
    public class EfMessageDal : GenericRepository<Message>, IMessageDal {
        public EfMessageDal(Context context) : base(context) {
        }
    }
}
