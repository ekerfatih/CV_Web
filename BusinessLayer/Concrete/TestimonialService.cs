using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService {
        public TestimonialManager(IGenericDal<Testimonial> genericDal) : base(genericDal) {
        }
    }
}
