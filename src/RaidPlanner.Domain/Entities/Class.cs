using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Entities;

public class Class
{
  public ClassIndentity Indentity { get; set; } = ClassIndentity.Unknown;

  public string Name { get; set; } = string.Empty;

  public Uri Wowhead { get; set; }

  public IEnumerable<Specialization> Specializations { get; set; } = [];
}
