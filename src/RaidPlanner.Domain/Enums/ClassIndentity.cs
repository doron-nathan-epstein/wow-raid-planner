namespace RaidPlanner.Domain.Enums;

/// <summary>
/// Represents the available character classes in the game.
/// </summary>
public enum ClassIndentity
{
  /// <summary>
  /// The character's class is unknown.
  /// </summary>
  /// <value>
  /// Default value of the enumeration. Indicates that the class has not been set or is undefined.
  /// </value>
  Unknown = 0,

  /// <summary>
  /// The Death Knight class.
  /// </summary>
  /// <value>
  /// A hero class that starts at a higher level and specializes in melee combat, tanking, and dark magic.
  /// </value>
  DeathKnight = 1,

  /// <summary>
  /// The Demon Hunter class.
  /// </summary>
  /// <value>
  /// A hero class with high mobility, focusing on melee damage and tanking, with fel and shadow magic abilities.
  /// </value>
  DemonHunter = 2,

  /// <summary>
  /// The Evoker class.
  /// </summary>
  /// <value>
  /// A mid-range class with access to both devastating damage and versatile healing, unique to Dracthyr.
  /// </value>
  Evoker = 3,

  /// <summary>
  /// The Druid class.
  /// </summary>
  /// <value>
  /// A shapeshifting hybrid class capable of fulfilling roles in tanking, healing, melee, or ranged damage.
  /// </value>
  Druid = 4,

  /// <summary>
  /// The Hunter class.
  /// </summary>
  /// <value>
  /// A ranged damage class with a focus on pets, ranged weapons, and nature-based abilities.
  /// </value>
  Hunter = 5,

  /// <summary>
  /// The Mage class.
  /// </summary>
  /// <value>
  /// A ranged damage class specializing in arcane, fire, and frost magic to deal powerful spell-based damage.
  /// </value>
  Mage = 6,

  /// <summary>
  /// The Monk class.
  /// </summary>
  /// <value>
  /// A versatile class capable of tanking, healing, or melee damage using martial arts and chi energy.
  /// </value>
  Monk = 7,

  /// <summary>
  /// The Paladin class.
  /// </summary>
  /// <value>
  /// A hybrid class specializing in tanking, healing, or melee damage, wielding holy magic and heavy armor.
  /// </value>
  Paladin = 8,

  /// <summary>
  /// The Priest class.
  /// </summary>
  /// <value>
  /// A healing and ranged damage class specializing in holy magic for healing or shadow magic for damage.
  /// </value>
  Priest = 9,

  /// <summary>
  /// The Rogue class.
  /// </summary>
  /// <value>
  /// A melee damage class focused on stealth, agility, and precision attacks with dual-wielded weapons.
  /// </value>
  Rogue = 10,

  /// <summary>
  /// The Shaman class.
  /// </summary>
  /// <value>
  /// A hybrid class capable of ranged damage, melee damage, or healing, using elemental and ancestral magic.
  /// </value>
  Shaman = 11,

  /// <summary>
  /// The Warlock class.
  /// </summary>
  /// <value>
  /// A ranged damage class specializing in dark magic, curses, and summoning demonic allies.
  /// </value>
  Warlock = 12,

  /// <summary>
  /// The Warrior class.
  /// </summary>
  /// <value>
  /// A melee class specializing in tanking or physical damage, with high durability and weapon mastery.
  /// </value>
  Warrior = 13,
}

