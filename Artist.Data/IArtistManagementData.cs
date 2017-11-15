using System;

namespace Artist.Data
{
    public interface IArtistManagementData
    {
        bool HasUser(Guid id);
    }
}