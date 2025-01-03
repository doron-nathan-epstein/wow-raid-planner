namespace RaidPlanner.Domain.Enums;

/// <summary>
/// Represents the various states a player can be in during their membership process or activity.
/// </summary>
public enum PlayerStatus
{
  /// <summary>
  /// The player's status is unknown.
  /// </summary>
  /// <value>
  /// Default value of the enumeration. Indicates that the player's status has not been set or is undefined.
  /// </value>
  Unknown = 0,

  /// <summary>
  /// The player is currently under review.
  /// </summary>
  /// <value>
  /// Indicates that the player's application or participation is being evaluated.
  /// </value>
  Review = 1,

  /// <summary>
  /// The player is in a trial period.
  /// </summary>
  /// <value>
  /// Indicates that the player is actively being assessed during a probationary or trial phase.
  /// </value>
  Trial = 2,

  /// <summary>
  /// The player has been confirmed as a full member.
  /// </summary>
  /// <value>
  /// Indicates that the player has successfully completed any review or trial processes.
  /// </value>
  Confirmed = 3,
}

