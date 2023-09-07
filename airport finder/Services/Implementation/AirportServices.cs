using airport_finder.Models;
using airport_finder.Repository;

namespace airport_finder.Services.Implementation
{
    public class AirportServices : IAirportService
    {
        private readonly IRepository<AirportInfo> _repository;
        public AirportServices(IRepository<AirportInfo> repository)
        {
            _repository = repository;
        }
        public void Add(AirportInfo Info)
        {
            _repository.Add(Info);
        }

        public List<AirportInfo> Get()
        {
            return _repository.Get();
        }
    }
}
