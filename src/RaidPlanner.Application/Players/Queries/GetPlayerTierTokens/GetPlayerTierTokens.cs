using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerTierTokens;

public record GetPlayerTierTokensQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerTierTokensQueryHandler : IRequestHandler<GetPlayerTierTokensQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerTierTokensQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Zenith", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
          (
            character.Class == ClassIndentity.Evoker || 
            character.Class == ClassIndentity.Monk || 
            character.Class == ClassIndentity.Rogue || 
            character.Class == ClassIndentity.Warrior
          ))) 
      },

      { "Dreadful", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
        (
          character.Class == ClassIndentity.DeathKnight || 
          character.Class == ClassIndentity.DemonHunter || 
          character.Class == ClassIndentity.Warlock
        ))) 
      },

      { "Mystic", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
        (
          character.Class == ClassIndentity.Druid || 
          character.Class == ClassIndentity.Hunter || 
          character.Class == ClassIndentity.Mage
        )))
      },

      { "Venerated", request.Players.Count(player => player.Characters.Any(character => character.IsMain && 
        (
          character.Class == ClassIndentity.Paladin || 
          character.Class == ClassIndentity.Priest || 
          character.Class == ClassIndentity.Shaman
        ))) 
      },
    };

    return await Task.FromResult(result);
  }
}
