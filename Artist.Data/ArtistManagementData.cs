using System;
using System.Linq;
using BC.Sharedkernel.Data;

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

        public void Update(Domain.Artist artist)
        {
            _artistContext.ChangeTracker.TrackGraph(artist, ChangeTrackerHelpers.ConvertStateOfNode);
            //_artistContext.FixState();
            _artistContext.SaveChanges();
        }
    }
}
