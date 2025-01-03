using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerTierTokens;

public record GetPlayerTierTokensQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerTierTokensQueryHandler : IRequestHandler<GetPlayerTierTokensQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerTierTokensQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Zenith", request.Players.Count(player => 
          player.Class == ClassIndentity.Evoker ||
          player.Class == ClassIndentity.Monk ||
          player.Class == ClassIndentity.Rogue ||
          player.Class == ClassIndentity.Warrior
        ) 
      },

      { "Dreadful", request.Players.Count(player => 
          player.Class == ClassIndentity.DeathKnight ||
          player.Class == ClassIndentity.DemonHunter ||
          player.Class == ClassIndentity.Warlock
        )
      },

      { "Mystic", request.Players.Count(player => 
          player.Class == ClassIndentity.Druid ||
          player.Class == ClassIndentity.Hunter ||
          player.Class == ClassIndentity.Mage
        )
      },

      { "Venerated", request.Players.Count(player => 
          player.Class == ClassIndentity.Paladin ||
          player.Class == ClassIndentity.Priest ||
          player.Class == ClassIndentity.Shaman
        )
      },
    };

    return await Task.FromResult(result);
  }
}
