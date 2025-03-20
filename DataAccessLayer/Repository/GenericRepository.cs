using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository {
    public class GenericRepository<T>(Context context) : IGenericDal<T> where T : class {
        private readonly Context _context = context;

        public void Delete(int id) {
            var entity = GetByID(id);
            if (entity != null) {
                _context.Remove(entity); 
                _context.SaveChanges();
            }
        }

        public T GetByID(int ID) => _context.Set<T>().Find(ID);

        public List<T> GetList() => _context.Set<T>().ToList();

        public void Insert(T t) {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t) {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
