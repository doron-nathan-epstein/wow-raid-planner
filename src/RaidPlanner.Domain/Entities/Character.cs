using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Entities;

public class Character
{
  public ClassIndentity Class { get; set; } = ClassIndentity.Unknown;

  public SpecializationIdentity MainSpec { get; set; } = SpecializationIdentity.Unknown;

  public SpecializationIdentity OffSpec { get; set; } = SpecializationIdentity.Unknown;

  public bool IsMain { get; set; } = false;
}
