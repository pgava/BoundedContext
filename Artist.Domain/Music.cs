using System;

namespace Artist.Domain
{
    public class Music
    {
        public int Id { get; set; }
        public Guid ArtistId { get; set; }
        public string Name { get; set; }
    }
}
