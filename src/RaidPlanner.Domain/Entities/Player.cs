using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Entities;

/// <summary>
/// Represents a player with details about their identity, status, and associated game characters.
/// </summary>
public class Player
{
  /// <summary>
  /// Gets or sets the player's display name.
  /// </summary>
  /// <value>
  /// The name that represents the player. Defaults to an empty string if not set.
  /// </value>
  public string Name { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the player's Discord username.
  /// </summary>
  /// <value>
  /// The username of the player on Discord, including the discriminator (e.g., Username#1234).
  /// Defaults to an empty string if not set.
  /// </value>
  public string DiscordUserName { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the player's Battle.net username.
  /// </summary>
  /// <value>
  /// The username of the player on Battle.net, including the identifier (e.g., Username#1234).
  /// Defaults to an empty string if not set.
  /// </value>
  public string BattlenetUserName { get; set; } = string.Empty;

  /// <summary>
  /// Gets or sets the current status of the player.
  /// </summary>
  /// <value>
  /// A value of the <see cref="PlayerStatus"/> enumeration indicating the player's current state.
  /// Defaults to <see cref="PlayerStatus.Review"/>.
  /// </value>
  public PlayerStatus Status { get; set; } = PlayerStatus.Review;

  /// <summary>
  /// Gets or sets the collection of characters associated with the player.
  /// </summary>
  /// <value>
  /// An <see cref="IEnumerable{T}"/> containing <see cref="Character"/> objects that represent the player's game characters.
  /// Defaults to an empty collection if not set.
  /// </value>
  public IEnumerable<Character> Characters { get; set; } = [];
}

