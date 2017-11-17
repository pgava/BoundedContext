using BC.Sharedkernel.Enums;
using BC.Sharedkernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BC.Sharedkernel.Data
{
  public static class Utilities
  {

    private static EntityState ConvertState(ObjectState state) {
      switch (state) {
        case ObjectState.Added:
          return EntityState.Added;

        case ObjectState.Modified:
          return EntityState.Modified;

        case ObjectState.Deleted:
          return EntityState.Deleted;

        default:
          return EntityState.Unchanged;
      }
    }

    public static void FixState(this DbContext context) {
      foreach (var entry in context.ChangeTracker.Entries<IStateObject>()) {
        IStateObject stateInfo = entry.Entity;
        entry.State = ConvertState(stateInfo.State);
      }
    }
  }
}