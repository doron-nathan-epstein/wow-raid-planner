using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Presentation.Utilities;

internal static class EnumStringUtilities
{
  public static string GetClass(ClassIndentity classIndentity)
  {
    return classIndentity == ClassIndentity.Unknown
      ? string.Empty
      : classIndentity.ToString();
  }

  public static string GetSpecialization(SpecializationIdentity specializationIndentity)
  {
    return specializationIndentity == SpecializationIdentity.Unknown
      ? string.Empty
      : specializationIndentity.ToString();
  }
}
