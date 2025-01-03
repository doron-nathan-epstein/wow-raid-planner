using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Presentation.Utilities;

internal static class EnumStringUtilities
{
  public static string GetClass(ClassIndentity classIndentity)
  {
    return classIndentity switch
    {
      ClassIndentity.Unknown => string.Empty,
      ClassIndentity.DeathKnight => "Death Knight",
      ClassIndentity.DemonHunter => "Demon Hunter",
      _ => classIndentity.ToString(),
    };
  }

  public static string GetSpecialization(SpecializationIdentity specializationIndentity)
  {
    return specializationIndentity switch
    {
      SpecializationIdentity.Unknown => string.Empty,
      SpecializationIdentity.BeastMastery => "Beast Mastery",
      _ => specializationIndentity.ToString(),
    };
  }
}
