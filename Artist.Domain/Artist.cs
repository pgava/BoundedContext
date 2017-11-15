using System;
using BC.Sharedkernel.Enums;
using BC.Sharedkernel.Interfaces;

namespace Artist.Domain
{
    public class Artist : IStateObject
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ObjectState State { get; private set; }

        private Artist()
        {
        }

        private Artist(Guid id, string name)
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
    }
}
