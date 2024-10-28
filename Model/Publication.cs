namespace ABCPublishingChallenge.Model
{
    public class Publication
    {
        public string Title { get; set; }
        public List<string> Content { get; set; }
        public List<Navigation> Navigation
        {
            get; set;
        }
    }
}
