using System;
using BC.Sharedkernel.Enums;
using BC.Sharedkernel.Interfaces;

namespace Artist.Domain
{
    public class Music : IStateObject
    {
        public int Id { get; private set; }
        public Guid ArtistId { get; private set; }
        public string Name { get; private set; }
        public ObjectState State { get; private set; }

        private Music()
        {
            
        }

        private Music(string name, Guid artistId)
        {
            Name = name;
            ArtistId = artistId;
            State = ObjectState.Added;
        }

        public static Music Create(string name, Guid artistId)
        {
            return new Music(name, artistId);
        }

        public void Update(string name)
        {
            if (Name != name)
            {
                Name = name;
                State = ObjectState.Modified;
            }
        }
    }
}
