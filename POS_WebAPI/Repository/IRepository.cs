using POS_WebAPI.Interface;

namespace POS_WebAPI.Repository
{
    public interface IRepository<TE> where TE : class
    {
        IEnumerable<TE> GetAll();
        IQueryable<TE?> GetQueryable();

        TE? GetById(string id);

        void Add(TE entity);
        void AddRange(ICollection<TE> entities);

        void Update(TE entity);
        void UpdateRange(ICollection<TE> entities);

        void Delete(TE entity);
        void DeleteRange(ICollection<TE> entities);
        int SaveChanges();
    }
}