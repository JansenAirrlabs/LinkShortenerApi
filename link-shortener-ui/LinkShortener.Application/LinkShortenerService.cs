using LinkShortener.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.Application
{
    public interface ILinkShortenerService
    {
        ShortenedLink ShortenLink(string url);
        List<ShortenedLink> GetShortenedLinks();
    }
    public class LinkShortenerService : ILinkShortenerService
    {
        public readonly IShortenedLinkRepo _shortenedLinkRepo;
        public LinkShortenerService(IShortenedLinkRepo shortenedLinkRepo)
        {
            _shortenedLinkRepo = shortenedLinkRepo;
        }
        public ShortenedLink ShortenLink(string url)
        {
            var shortUrl = GenerateShortUrl();
            var link = new ShortenedLink { OriginalUrl = url, ShortUrl = shortUrl };
            _shortenedLinkRepo.AddShortenedLink(link);
            return link;
        }

        public List<ShortenedLink> GetShortenedLinks()
        {
            return _shortenedLinkRepo.GetAllShortenedLink();
        }

        private string GenerateShortUrl()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}
