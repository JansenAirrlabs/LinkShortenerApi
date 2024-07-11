using LinkShortener.Api.Request;
using LinkShortener.Application;
using LinkShortener.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortener.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkController : ControllerBase
    {
        private readonly ILinkShortenerService _linkShortenerService;

        public LinkController(ILinkShortenerService linkShortenerService)
        {
            _linkShortenerService = linkShortenerService;
        }

        [HttpPost]
        public ActionResult<ShortenedLink> ShortenLink(ShortenLinkRequest request)
        {
            var link = _linkShortenerService.ShortenLink(request.url);
            return Ok(link);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ShortenedLink>> GetShortenedLinks()
        {
            var links =  _linkShortenerService.GetShortenedLinks();
            return Ok(links);
        }
    }
}
