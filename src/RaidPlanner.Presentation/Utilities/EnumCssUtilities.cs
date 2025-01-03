using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Presentation.Utilities;

internal static class EnumCssUtilities
{
  public static string GetClassColor(ClassIndentity classIndentity)
  {
    if (classIndentity == ClassIndentity.Unknown)
    {
      return string.Empty;
    }

    return $"text-bg-{EnumStringUtilities.GetClass(classIndentity).ToLower()}";
  }
}
