using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Entities;

public class Specialization
{
  public SpecializationIdentity Indentity { get; set; } = SpecializationIdentity.Unknown;

  public string Name { get; set; } = string.Empty;

  public Role Role { get; set; } = Role.Unknown;

  public Uri Wowhead { get; set; }
}
