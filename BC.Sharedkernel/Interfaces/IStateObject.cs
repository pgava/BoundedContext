using BC.Sharedkernel.Enums;

namespace BC.Sharedkernel.Interfaces
{
  public interface IStateObject
  {
    ObjectState State { get; }
  }
}