using ABCPublishingChallenge.Model;
using Newtonsoft.Json;

namespace ABCPublishingChallenge.Service
{
    public class PublicationService : IPublicationService
    {
        public Dictionary<string, Publication> DeserializeJsonToDictionary()
        {
            var readJsonFile = File.ReadAllText(@"the-adventures-of-sherlock-holmes-sample.json");
            var data = JsonConvert.DeserializeObject<Dictionary<string, Publication>>(readJsonFile);

            return data;
        }
    }
}
