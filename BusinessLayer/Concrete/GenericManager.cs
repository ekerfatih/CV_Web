using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete {
    public class GenericManager<T>(IGenericDal<T> genericDal) : IGenericService<T> where T : class {
        private readonly IGenericDal<T> _genericDal = genericDal;

        public void TInsert(T t) {
            _genericDal.Insert(t);
        }

        public void TDelete(int ID) {
            _genericDal.Delete(ID);
        }

        public void TUpdate(T t) {
            _genericDal.Update(t);
        }

        public T TGetByID(int ID) {
            return _genericDal.GetByID(ID);
        }

        public List<T> TGetList() {
            return _genericDal.GetList();
        }
    }
}
