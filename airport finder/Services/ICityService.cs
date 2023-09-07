using airport_finder.Models;

namespace airport_finder.Services
{
    public interface ICityService
    {
        void Add(CityInfo Info);
        List<CityInfo> Get();
    }
}
