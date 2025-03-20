using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class SocialMediaManager : GenericManager<SocialMedia>, ISocialMediaService {
        public SocialMediaManager(IGenericDal<SocialMedia> genericDal) : base(genericDal) {
        }
    }
}
