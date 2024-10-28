using ABCPublishingChallenge.Model;
using ABCPublishingChallenge.Service;
using Microsoft.AspNetCore.Mvc;

namespace ABCPublishingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : Controller
    {
        private readonly IPublicationService _publicationService;

        public PublicationController(IPublicationService publicationService)
        {
            _publicationService = publicationService;
        }

        [HttpGet]
        public IActionResult GetWholePublication()
        {
            Dictionary<string, Publication> data = _publicationService.DeserializeJsonToDictionary();

            return Ok(data);
        }
    }
}
