using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Entities;

public class Character
{
  public Class Class { get; set; } = Class.Unknown;

  public Specialization MainSpec { get; set; } = Specialization.Unknown;

  public Specialization OffSpec { get; set; } = Specialization.Unknown;

  public bool IsMain { get; set; } = false;
}
