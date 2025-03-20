using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class ContactManager : GenericManager<Contact>, IContactService {

        public ContactManager(IContactDal contactDal) : base(contactDal) {
        }
    }
}
