using BC.Sharedkernel.Enums;
using BC.Sharedkernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BC.Sharedkernel.Data
{
    public static class ChangeTrackerHelpers
    {
        public static void ConvertStateOfNode(EntityEntryGraphNode node)
        {
            IStateObject entity = (IStateObject)node.Entry.Entity;
            node.Entry.State = ConvertToEfState(entity.State);
        }
        private static EntityState ConvertToEfState(ObjectState objectState)
        {
            EntityState efState = EntityState.Unchanged;
            switch (objectState)
            {
                case ObjectState.Added:
                    efState = EntityState.Added;
                    break;
                case ObjectState.Modified:
                    efState = EntityState.Modified;
                    break;
                case ObjectState.Deleted:
                    efState = EntityState.Deleted;
                    break;
                case ObjectState.Unchanged:
                    efState = EntityState.Unchanged;
                    break;
            }
            return efState;
        }
    }
}
