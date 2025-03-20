
namespace DataAccessLayer.Abstract {
    public interface IGenericDal<T> {
        void Insert(T t);
        void Delete(int ID);
        void Update(T t);
        List<T> GetList();
        T GetByID(int ID);
    }
}
