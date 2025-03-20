using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete {
    public class FeatureManager(IFeatureDal featureDal) : GenericManager<Feature>(featureDal), IFeatureService {

    }
}
