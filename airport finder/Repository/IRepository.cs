namespace airport_finder.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T Entity);
        List<T> Get();
    }
}
