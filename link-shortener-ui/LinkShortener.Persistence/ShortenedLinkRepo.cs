using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.Persistence
{
    public interface IShortenedLinkRepo
    {
        void AddShortenedLink(ShortenedLink shortenedLink);
        List<ShortenedLink> GetAllShortenedLink();
    }
    public class ShortenedLinkRepo : IShortenedLinkRepo
    {
        protected readonly ShortenedLinkDBContext _context;
        public ShortenedLinkRepo(ShortenedLinkDBContext context)
        {
            _context = context;
        }

        public void AddShortenedLink(ShortenedLink shortenedLink)
        {
            _context.ShortenedLink.Add(shortenedLink);
            _context.SaveChanges();
        }
        public List<ShortenedLink> GetAllShortenedLink()
        {
            var allShortenedLink = _context.ShortenedLink.ToList();
            return allShortenedLink;
        }
    }
}
