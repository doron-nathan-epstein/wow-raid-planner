using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.Common;

public class SimplePlayerDto
{
  public string Name { get; set; } = string.Empty;

  public ClassIndentity Class { get; set; } = ClassIndentity.Unknown;

  public SpecializationIdentity Spec { get; set; } = SpecializationIdentity.Unknown;

  public Role Role { get; set; } = Role.Unknown;
}
