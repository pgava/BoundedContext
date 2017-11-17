using System;
using System.Collections.Generic;
using BC.Sharedkernel.Enums;
using BC.Sharedkernel.Interfaces;

namespace Artist.Domain
{
    public class Artist : IStateObject
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ObjectState State { get; private set; }
        public List<Music> Musics { get; private set; }

        private Artist()
        {
            Musics = new List<Music>();
        }

        private Artist(Guid id, string name) : this()
        {
            Id = id;
            Name = name;
            State = ObjectState.Added;
        }

        public static Artist Create(Guid id, string name)
        {
            return new Artist(id, name);
        }

        public void Update(string name)
        {
            if (Name != name)
            {
                Name = name;
                State = ObjectState.Modified;
            }
        }

        public void AddMusic(string name)
        {
            Musics.Add(Music.Create(name, Id));
        }
    }
}
