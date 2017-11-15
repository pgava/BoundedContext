using System;
using Artist.Data;

namespace Artist.Service
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistManagementData _artistManagementData;

        public ArtistService(IArtistManagementData artistManagementData)
        {
            _artistManagementData = artistManagementData;
        }

        public bool SomeUsefulMethod(Guid id)
        {
            return _artistManagementData.HasUser(id);
        }
    }
}
