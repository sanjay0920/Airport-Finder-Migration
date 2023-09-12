using airport_finder.Models;
using airport_finder.Repository;

namespace airport_finder.Services.Implementation
{
    public class AirportServices : IAirportService
    {
        private readonly IRepository<AirportInfo> _repository;
        public AirportServices(IRepository<AirportInfo> repository, ICityService @object)
        {
            _repository = repository;
        }
        public void Add(AirportInfo Info)
        {
            _repository.Add(Info);

        }
        public List<AirportInfo> GetAirportsByState(string id)
        {
            return _repository.Get().Where(x => x.State == id).ToList();
        }
        public List<AirportInfo> Get()
        {
            return _repository.Get();
        }
    }
}
