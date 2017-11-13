using System;

namespace Artist.Domain
{
    public class ArtistMember
    {
        public int Id { get; set; }
        public Guid ArtistId { get; set; }
        public Guid UserId { get; set; }
    }
}
