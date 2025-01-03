using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Domain.Constants;

public static class Classes
{
  private static readonly IEnumerable<Class> _classes = new List<Class>
  {
    DeathKnight(),
    DemonHunter(),
    Druid(),
    Evoker(),
    Hunter(),
    Mage(),
    Monk(),
    Paladin(),
    Priest(),
    Rogue(),
    Shaman(),
    Warlock(),
    Warrior(),
  };

  public static IEnumerable<Class> Get() => _classes;

  private static Class DeathKnight()
  {
    return new Class
    {
      Indentity = ClassIndentity.DeathKnight,
      Name = "Death Knight",
      Wowhead = new Uri("https://www.wowhead.com/class=6/death-knight"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Blood,
          Name = "Blood",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/death-knight/blood/overview-pve-tank")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Frost,
          Name = "Frost",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/death-knight/frost/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Unholy,
          Name = "Unholy",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/death-knight/unholy/overview-pve-dps")
        },
      }
    };
  }

  private static Class DemonHunter()
  {
    return new Class
    {
      Indentity = ClassIndentity.DemonHunter,
      Name = "Demon Hunter",
      Wowhead = new Uri("https://www.wowhead.com/class=12/demon-hunter"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Havoc,
          Name = "Havoc",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/demon-hunter/havoc/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Vengeance,
          Name = "Vengeance",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/demon-hunter/vengeance/overview-pve-tank")
        },
      }
    };
  }

  private static Class Druid()
  {
    return new Class
    {
      Indentity = ClassIndentity.Druid,
      Name = "Druid",
      Wowhead = new Uri("https://www.wowhead.com/class=11/druid"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Balance,
          Name = "Balance",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/druid/balance/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Feral,
          Name = "Feral",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/druid/feral/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Guardian,
          Name = "Guardian",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/druid/guardian/overview-pve-tank")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Restoration,
          Name = "Restoration",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/druid/restoration/overview-pve-healer")
        },
      }
    };
  }

  private static Class Evoker()
  {
    return new Class
    {
      Indentity = ClassIndentity.Evoker,
      Name = "Evoker",
      Wowhead = new Uri("https://www.wowhead.com/class=13/evoker"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Augmentation,
          Name = "Augmentation",
          Role = Role.Support,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/evoker/augmentation/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Devastation,
          Name = "Devastation",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/evoker/devastation/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Preservation,
          Name = "Guardian",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/evoker/preservation/overview-pve-healer")
        },
      }
    };
  }

  private static Class Hunter()
  {
    return new Class
    {
      Indentity = ClassIndentity.Hunter,
      Name = "Hunter",
      Wowhead = new Uri("https://www.wowhead.com/class=3/hunter"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.BeastMastery,
          Name = "Beast Mastery",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/hunter/beast-mastery/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Marksmanship,
          Name = "Marksmanship",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/hunter/marksmanship/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Survival,
          Name = "Survival",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/hunter/survival/overview-pve-dps")
        },
      }
    };
  }

  private static Class Mage()
  {
    return new Class
    {
      Indentity = ClassIndentity.Mage,
      Name = "Mage",
      Wowhead = new Uri("https://www.wowhead.com/class=8/mage"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Arcane,
          Name = "Arcane",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/mage/arcane/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Fire,
          Name = "Fire",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/mage/fire/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Frost,
          Name = "Frost",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/mage/frost/overview-pve-dps")
        },
      }
    };
  }

  private static Class Monk()
  {
    return new Class
    {
      Indentity = ClassIndentity.Monk,
      Name = "Monk",
      Wowhead = new Uri("https://www.wowhead.com/class=10/monk"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Brewmaster,
          Name = "Brewmaster",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/monk/brewmaster/overview-pve-tank")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Mistweaver,
          Name = "Mistweaver",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/monk/mistweaver/overview-pve-healer")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Windwalker,
          Name = "Windwalker",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/monk/windwalker/overview-pve-dps")
        },
      }
    };
  }

  private static Class Paladin()
  {
    return new Class
    {
      Indentity = ClassIndentity.Paladin,
      Name = "Paladin",
      Wowhead = new Uri("https://www.wowhead.com/class=2/paladin"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Holy,
          Name = "Holy",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/paladin/holy/overview-pve-healer")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Protection,
          Name = "Protection",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/paladin/protection/overview-pve-tank")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Retribution,
          Name = "Retribution",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/paladin/retribution/overview-pve-dps")
        },
      }
    };
  }

  private static Class Priest()
  {
    return new Class
    {
      Indentity = ClassIndentity.Priest,
      Name = "Priest",
      Wowhead = new Uri("https://www.wowhead.com/class=5/priest"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Discipline,
          Name = "Discipline",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/priest/discipline/overview-pve-healer")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Holy,
          Name = "Holy",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/priest/holy/overview-pve-healer")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Shadow,
          Name = "Shadow",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/priest/shadow/overview-pve-dps")
        },
      }
    };
  }

  private static Class Rogue()
  {
    return new Class
    {
      Indentity = ClassIndentity.Rogue,
      Name = "Rogue",
      Wowhead = new Uri("https://www.wowhead.com/class=4/rogue"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Assassination,
          Name = "Assassination",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/rogue/assassination/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Outlaw,
          Name = "Outlaw",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/rogue/outlaw/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Subtlety,
          Name = "Subtlety",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/rogue/subtlety/overview-pve-dps")
        },
      }
    };
  }

  private static Class Shaman()
  {
    return new Class
    {
      Indentity = ClassIndentity.Shaman,
      Name = "Shaman",
      Wowhead = new Uri("https://www.wowhead.com/class=7/shaman"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Elemental,
          Name = "Elemental",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/shaman/elemental/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Enhancement,
          Name = "Enhancement",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/shaman/enhancement/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Restoration,
          Name = "Restoration",
          Role = Role.Healer,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/shaman/restoration/overview-pve-healer")
        },
      }
    };
  }

  private static Class Warlock()
  {
    return new Class
    {
      Indentity = ClassIndentity.Warlock,
      Name = "Warlock",
      Wowhead = new Uri("https://www.wowhead.com/class=9/warlock"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Affliction,
          Name = "Affliction",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warlock/affliction/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Demonology,
          Name = "Demonology",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warlock/demonology/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Destruction,
          Name = "Destruction",
          Role = Role.Range,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warlock/destruction/overview-pve-dps")
        },
      }
    };
  }

  private static Class Warrior()
  {
    return new Class
    {
      Indentity = ClassIndentity.Warrior,
      Name = "Warrior",
      Wowhead = new Uri("https://www.wowhead.com/class=1/warrior"),
      Specializations = new[] {
        new Specialization {
          Indentity = SpecializationIdentity.Arms,
          Name = "Arms",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warrior/arms/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Fury,
          Name = "Fury",
          Role = Role.Melee,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warrior/fury/overview-pve-dps")
        },
        new Specialization {
          Indentity = SpecializationIdentity.Protection,
          Name = "Protection",
          Role = Role.Tank,
          Wowhead = new Uri("https://www.wowhead.com/guide/classes/warrior/protection/overview-pve-tank")
        },
      }
    };
  }
}
