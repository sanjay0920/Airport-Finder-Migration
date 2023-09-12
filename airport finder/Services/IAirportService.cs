using airport_finder.Models;

namespace airport_finder.Services
{
    public interface IAirportService
    {
        void Add(AirportInfo Info);
        List<AirportInfo> Get();
        List<AirportInfo> GetAirportsByState(string id);

    }
}
