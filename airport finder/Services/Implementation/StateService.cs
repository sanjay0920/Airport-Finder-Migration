using airport_finder.Models;
using airport_finder.Repository;

namespace airport_finder.Services.Implementation
{
    public class StateService : IStateService
    {
        private readonly IRepository<StateImg> _repository;
        public StateService(IRepository<StateImg> repository)
        {
            _repository = repository;
        }
        public void Add(StateImg Info)
        {
            _repository.Add(Info);
        }

        public List<StateImg> Get()
        {
            return _repository.Get();
        }
    }
}
