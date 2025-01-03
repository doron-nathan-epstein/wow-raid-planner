using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMinorUtilities;

public record GetPlayerMinorUtilitiesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerMinorUtilitiesQueryHandler : IRequestHandler<GetPlayerMinorUtilitiesQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerMinorUtilitiesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Knock Up/Back", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
        (
            character.Class == ClassIndentity.Druid ||  
            character.Class == ClassIndentity.Evoker || 
            character.Class == ClassIndentity.Hunter ||
            character.Class == ClassIndentity.Mage ||
            character.Class == ClassIndentity.Monk ||
            character.Class == ClassIndentity.Shaman
          ))) 
      },

      { "Mortal Strike", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            character.Class == ClassIndentity.Rogue || 
            (character.Class == ClassIndentity.Warrior && character.MainSpec == SpecializationIdentity.Arms) ||
            (character.Class == ClassIndentity.DemonHunter && character.MainSpec == SpecializationIdentity.Havoc)
          )))  
      },
      
      { "Soothe", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            character.Class == ClassIndentity.Druid || 
            character.Class == ClassIndentity.Evoker ||
            character.Class == ClassIndentity.Hunter ||  
            character.Class == ClassIndentity.Monk
          ))) 
      },

      { "Purge", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            character.Class == ClassIndentity.Hunter || 
            character.Class == ClassIndentity.Mage ||
            character.Class == ClassIndentity.Priest ||  
            character.Class == ClassIndentity.Shaman
          ))) 
      },

      { "Power Infusion", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Priest)) },

      { "Extra Dam to Shields", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            character.Class == ClassIndentity.Evoker || 
            character.Class == ClassIndentity.Warrior
          ))) 
      },

      { "Cheat Death", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            (character.Class == ClassIndentity.DeathKnight && character.MainSpec == SpecializationIdentity.Blood) || 
            (character.Class == ClassIndentity.DemonHunter && character.MainSpec == SpecializationIdentity.Vengeance) || 
            (character.Class == ClassIndentity.Evoker && character.MainSpec == SpecializationIdentity.Augmentation) ||           
            (character.Class == ClassIndentity.Mage && character.MainSpec == SpecializationIdentity.Fire) || 
            (character.Class == ClassIndentity.Priest && character.MainSpec == SpecializationIdentity.Holy) || 
            character.Class == ClassIndentity.Rogue
          ))) 
      },

      { "Blessing of Spellwarding", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Paladin && character.MainSpec == SpecializationIdentity.Protection)) },
    };

    return await Task.FromResult(result);
  }
}
