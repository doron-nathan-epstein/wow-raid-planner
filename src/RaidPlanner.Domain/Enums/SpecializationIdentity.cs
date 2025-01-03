namespace RaidPlanner.Domain.Enums;

/// <summary>
/// Represents the available specializations for classes in the game.
/// </summary>
public enum SpecializationIdentity
{
  /// <summary>
  /// The specialization is unknown.
  /// </summary>
  /// <value>
  /// Default value of the enumeration. Indicates that the specialization has not been set or is undefined.
  /// </value>
  Unknown = 0,

  /// <summary>
  /// The Affliction specialization.
  /// </summary>
  /// <value>
  /// A Warlock specialization focused on damage over time effects and curses.
  /// </value>
  Affliction = 1,

  /// <summary>
  /// The Arcane specialization.
  /// </summary>
  /// <value>
  /// A Mage specialization that uses arcane magic for powerful and efficient ranged damage.
  /// </value>
  Arcane = 2,

  /// <summary>
  /// The Arms specialization.
  /// </summary>
  /// <value>
  /// A Warrior specialization focused on precise, powerful strikes and mastery of weapons.
  /// </value>
  Arms = 3,

  Assassination = 4,

  /// <summary>
  /// The Augmentation specialization.
  /// </summary>
  /// <value>
  /// An Evoker specialization that enhances allies' abilities and supports the team.
  /// </value>
  Augmentation = 5,

  /// <summary>
  /// The Balance specialization.
  /// </summary>
  /// <value>
  /// A Druid specialization focused on ranged damage using lunar and solar magic.
  /// </value>
  Balance = 6,

  /// <summary>
  /// The Beast Mastery specialization.
  /// </summary>
  /// <value>
  /// A Hunter specialization focused on ranged damage and commanding animal companions.
  /// </value>
  BeastMastery = 7,

  /// <summary>
  /// The Blood specialization.
  /// </summary>
  /// <value>
  /// A Death Knight specialization focused on tanking and self-healing using vampiric abilities.
  /// </value>
  Blood = 8,

  /// <summary>
  /// The Brewmaster specialization.
  /// </summary>
  /// <value>
  /// A Monk specialization focused on tanking and mitigating damage with elusive techniques.
  /// </value>
  Brewmaster = 9,

  Demonology = 10,

  /// <summary>
  /// The Destruction specialization.
  /// </summary>
  /// <value>
  /// A Warlock specialization focused on high burst damage using chaos and fire magic.
  /// </value>
  Destruction = 11,

  /// <summary>
  /// The Devastation specialization.
  /// </summary>
  /// <value>
  /// An Evoker specialization focused on dealing high burst damage from mid-range.
  /// </value>
  Devastation = 12,

  /// <summary>
  /// The Discipline specialization.
  /// </summary>
  /// <value>
  /// A Priest specialization that blends healing and shielding allies with offensive abilities.
  /// </value>
  Discipline = 13,

  /// <summary>
  /// The Elemental specialization.
  /// </summary>
  /// <value>
  /// A Shaman specialization focused on ranged damage using elemental magic.
  /// </value>
  Elemental = 14,

  /// <summary>
  /// The Enhancement specialization.
  /// </summary>
  /// <value>
  /// A Shaman specialization focused on melee damage using elemental-infused weapons.
  /// </value>
  Enhancement = 15,

  /// <summary>
  /// The Feral specialization.
  /// </summary>
  /// <value>
  /// A Druid specialization focused on melee damage using shapeshifting and bleed effects.
  /// </value>
  Feral = 16,

  /// <summary>
  /// The Fire specialization.
  /// </summary>
  /// <value>
  /// A Mage specialization focused on dealing damage with fire magic and high burst potential.
  /// </value>
  Fire = 17,

  /// <summary>
  /// The Frost specialization.
  /// </summary>
  /// <value>
  /// A specialization available to Mages and Death Knights, focusing on frost magic or melee damage with icy abilities.
  /// </value>
  Frost = 18,

  /// <summary>
  /// The Fury specialization.
  /// </summary>
  /// <value>
  /// A Warrior specialization focused on high-paced melee damage with dual-wielded weapons.
  /// </value>
  Fury = 19,

  /// <summary>
  /// The Guardian specialization.
  /// </summary>
  /// <value>
  /// A Druid specialization focused on tanking and absorbing damage with high durability.
  /// </value>
  Guardian = 20,

  /// <summary>
  /// The Havoc specialization.
  /// </summary>
  /// <value>
  /// A Demon Hunter specialization focused on high-mobility melee damage.
  /// </value>
  Havoc = 21,

  /// <summary>
  /// The Holy specialization.
  /// </summary>
  /// <value>
  /// A specialization available to Priests and Paladins, focusing on healing and supporting allies.
  /// </value>
  Holy = 22,

  /// <summary>
  /// The Marksmanship specialization.
  /// </summary>
  /// <value>
  /// A Hunter specialization focused on precise ranged damage without relying heavily on pets.
  /// </value>
  Marksmanship = 23,

  /// <summary>
  /// The Mistweaver specialization.
  /// </summary>
  /// <value>
  /// A Monk specialization focused on healing and supporting allies with chi-based techniques.
  /// </value>
  Mistweaver = 24,

  /// <summary>
  /// The Outlaw specialization.
  /// </summary>
  /// <value>
  /// A Rogue specialization focused on melee damage and swashbuckling combat techniques.
  /// </value>
  Outlaw = 25,

  /// <summary>
  /// The Preservation specialization.
  /// </summary>
  /// <value>
  /// An Evoker specialization focused on healing and mitigating damage for allies.
  /// </value>
  Preservation = 26,

  /// <summary>
  /// The Protection specialization.
  /// </summary>
  /// <value>
  /// A specialization available to Paladins and Warriors, focusing on tanking and absorbing damage.
  /// </value>
  Protection = 27,

  /// <summary>
  /// The Restoration specialization.
  /// </summary>
  /// <value>
  /// A specialization available to Druids and Shamans, focusing on healing and sustaining allies.
  /// </value>
  Restoration = 28,

  /// <summary>
  /// The Retribution specialization.
  /// </summary>
  /// <value>
  /// A Paladin specialization focused on melee damage with holy magic.
  /// </value>
  Retribution = 29,

  /// <summary>
  /// The Shadow specialization.
  /// </summary>
  /// <value>
  /// A Priest specialization focused on dealing ranged damage with shadow magic.
  /// </value>
  Shadow = 30,

  /// <summary>
  /// The Subtlety specialization.
  /// </summary>
  /// <value>
  /// A Rogue specialization focused on stealth and precision melee damage.
  /// </value>
  Subtlety = 31,

  /// <summary>
  /// The Survival specialization.
  /// </summary>
  /// <value>
  /// A Hunter specialization focused on melee damage and traps.
  /// </value>
  Survival = 32,

  Unholy = 33,

  /// <summary>
  /// The Vengeance specialization.
  /// </summary>
  /// <value>
  /// A Demon Hunter specialization focused on tanking and self-sustain through damage mitigation.
  /// </value>
  Vengeance = 34,

  /// <summary>
  /// The Windwalker specialization.
  /// </summary>
  /// <value>
  /// A Monk specialization focused on high-mobility melee damage using martial arts techniques.
  /// </value>
  Windwalker = 35,
}
