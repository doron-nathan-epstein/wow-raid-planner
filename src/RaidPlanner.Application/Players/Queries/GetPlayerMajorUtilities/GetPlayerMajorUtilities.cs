using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMajorUtilities;

public record GetPlayerMajorUtilitiesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerMajorUtilitiesQueryHandler : IRequestHandler<GetPlayerMajorUtilitiesQuery, IDictionary<string, int>>
{
  public async Task<IDictionary<string, int>> Handle(GetPlayerMajorUtilitiesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Bloodlust", request.Players.Count(player => 
          player.Class == ClassIndentity.Mage || 
          player.Class == ClassIndentity.Evoker || 
          player.Class == ClassIndentity.Shaman
        ) 
      },

      { "Combat Res", request.Players.Count(player => 
          player.Class == ClassIndentity.DeathKnight || 
          player.Class == ClassIndentity.Druid || 
          player.Class == ClassIndentity.Paladin || 
          player.Class == ClassIndentity.Warlock
        ) 
      },

      { "Burst Move Speed", request.Players.Count(player => 
          player.Class == ClassIndentity.Druid || 
          player.Class == ClassIndentity.Shaman
        ) 
      },

      { "Lock Stuff (HS, Gate, Curse)", request.Players.Count(player => player.Class == ClassIndentity.Warlock) },

      { "Mass Dispel", request.Players.Count(player => 
          player.Class == ClassIndentity.Monk || 
          player.Class == ClassIndentity.Priest
        ) 
      },

      { "Innervate", request.Players.Count(player => player.Class == ClassIndentity.Druid) },

      { "Death Grip", request.Players.Count(player => player.Class == ClassIndentity.DeathKnight) },

      { "Blessing of Protection", request.Players.Count(player => player.Class == ClassIndentity.Paladin) },

      { "Rallying Cry", request.Players.Count(player => player.Class == ClassIndentity.Warrior) },

      { "Darkness", request.Players.Count(player => player.Class == ClassIndentity.DemonHunter) },

      { "Immunities", request.Players.Count(player => 
          player.Class == ClassIndentity.Hunter || 
          player.Class == ClassIndentity.Mage || 
          player.Class == ClassIndentity.Paladin
        ) 
      },

      { "Windfury", request.Players.Count(player => player.Class == ClassIndentity.Shaman && player.Spec == SpecializationIdentity.Enhancement) },

      { "Boss DR", request.Players.Count(player => player.Class == ClassIndentity.Rogue) },

      { "Dragons", request.Players.Count(player => player.Class == ClassIndentity.Evoker) },

      { "Execute Damage", request.Players.Count(player => 
          player.Class == ClassIndentity.Hunter ||
          (player.Class == ClassIndentity.Mage && player.Spec == SpecializationIdentity.Fire) ||
          player.Class == ClassIndentity.Paladin || 
          player.Class == ClassIndentity.Priest ||
          (player.Class == ClassIndentity.Rogue && player.Spec == SpecializationIdentity.Assassination) ||
          player.Class == ClassIndentity.Warrior
        ) 
      },

      { "Attack Speed Reduction", request.Players.Count(player => 
          player.Class == ClassIndentity.DeathKnight || 
          player.Class == ClassIndentity.Rogue || 
          player.Class == ClassIndentity.Warlock
        ) 
      },

      { "Cast Speed Reduction", request.Players.Count(player => 
          player.Class == ClassIndentity.Rogue ||
          player.Class == ClassIndentity.Warlock
        ) 
      },

      { "Skyfury", request.Players.Count(player => player.Class == ClassIndentity.Shaman) },
    };

    return await Task.FromResult(result);
  }
}
