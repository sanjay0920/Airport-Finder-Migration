using airport_finder.Models;

namespace airport_finder.Services
{
    public interface IStateService
    {
        void Add(StateImg Info);
        List<StateImg> Get();
    }
}

