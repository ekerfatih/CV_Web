namespace BusinessLayer.Abstract {
    public interface IGenericService<T> {
        void TInsert(T t);
        void TDelete(int ID);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int ID);
    }
}
