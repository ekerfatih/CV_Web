using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class MessageManager : GenericManager<Message>, IMessageService {
        public MessageManager(IGenericDal<Message> genericDal) : base(genericDal) {
        }
    }
}
