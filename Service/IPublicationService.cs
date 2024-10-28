using ABCPublishingChallenge.Model;

namespace ABCPublishingChallenge.Service
{
    public interface IPublicationService
    {
        Dictionary<string, Publication> DeserializeJsonToDictionary();
    }
}
