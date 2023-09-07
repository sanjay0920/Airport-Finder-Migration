using airport_finder.Models;
using airport_finder.Repository;

namespace airport_finder.Services.Implementation
{
    public class FeedBackService : IFeedBackService
    {
        private readonly IRepository<FeedBack> _repository;
        public FeedBackService(IRepository<FeedBack> repository)
        {
            _repository = repository;
        }
        public void Add(FeedBack Info)
        {
            _repository.Add(Info);
        }

        public List<FeedBack> Get()
        {
            return _repository.Get();
        }
    }
}