using System;
using System.Linq;

namespace Artist.Data
{
    public class ArtistManagementData : IArtistManagementData
    {
        private readonly ArtistContext _artistContext;
        private readonly UserReferenceContext _userReferenceContext;

        public ArtistManagementData(ArtistContext artistContext, UserReferenceContext userReferenceContext)
        {
            _artistContext = artistContext;
            _userReferenceContext = userReferenceContext;
        }

        public bool HasUser(Guid id)
        {
            return _userReferenceContext.Users.Any(u => u.Id == id);
        }
    }
}
