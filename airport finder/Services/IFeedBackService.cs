using airport_finder.Models;

namespace airport_finder.Services
{
    public interface IFeedBackService
    {
        void Add(FeedBack Info);
        List<FeedBack> Get();
    }
}