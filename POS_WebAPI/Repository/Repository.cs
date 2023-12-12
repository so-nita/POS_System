using POS_WebAPI.DataContext;

namespace POS_WebAPI.Repository
{
    public class Repository<TE> : IRepository<TE> where TE : class
    {
        private readonly PosContext _context;
        public Repository(PosContext context)
        {
            _context = context;
        }

        public IEnumerable<TE> GetAll() => _context.Set<TE>().ToList();

        public TE? GetById(string id)
        {
            return _context.Set<TE>().Find(id);
        }

        public IQueryable<TE?> GetQueryable()
        {
            return _context.Set<TE>().AsQueryable();
        }
        public void Add(TE entity)
        {
            _context.Set<TE>().Add(entity);
        }

        public void AddRange(ICollection<TE> entities)
        {
            _context.Set<TE>().AddRange(entities);
        }

        public void Update(TE entity)
        {
            _context.Set<TE>().Update(entity);
        }

        public void UpdateRange(ICollection<TE> entities)
        {
            _context.Set<TE>().UpdateRange(entities);

        }
        public void Delete(TE entity)
        {
            _context.Set<TE>().Remove(entity);
        }

        public void DeleteRange(ICollection<TE> entities)
        {
            _context.Set<TE>().RemoveRange(entities);
        }
        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
    }
}
