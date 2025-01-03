using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMinorUtilities;

public record GetPlayerMinorUtilitiesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerMinorUtilitiesQueryHandler : IRequestHandler<GetPlayerMinorUtilitiesQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerMinorUtilitiesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Knock Up/Back", request.Players.Count(player => 
          player.Class == ClassIndentity.Druid ||
          player.Class == ClassIndentity.Evoker ||
          player.Class == ClassIndentity.Hunter ||
          player.Class == ClassIndentity.Mage ||
          player.Class == ClassIndentity.Monk ||
          player.Class == ClassIndentity.Shaman
        )
      },

      { "Mortal Strike", request.Players.Count(player =>
          (player.Class == ClassIndentity.DemonHunter && player.Spec == SpecializationIdentity.Havoc) ||
          player.Class == ClassIndentity.Rogue || 
          (player.Class == ClassIndentity.Warrior && player.Spec == SpecializationIdentity.Arms)
        )
      },
      
      { "Soothe", request.Players.Count(player =>
          player.Class == ClassIndentity.Druid ||
          player.Class == ClassIndentity.Evoker ||
          player.Class == ClassIndentity.Hunter ||
          player.Class == ClassIndentity.Monk
        )
      },

      { "Purge", request.Players.Count(player => 
          player.Class == ClassIndentity.Hunter ||
          player.Class == ClassIndentity.Mage ||
          player.Class == ClassIndentity.Priest ||
          player.Class == ClassIndentity.Shaman
        )
      },

      { "Power Infusion", request.Players.Count(player => player.Class == ClassIndentity.Priest) },

      { "Extra Dam to Shields", request.Players.Count(player => 
          player.Class == ClassIndentity.Evoker ||
          player.Class == ClassIndentity.Warrior
        )
      },

      { "Cheat Death", request.Players.Count(player => 
          (player.Class == ClassIndentity.DeathKnight && player.Spec == SpecializationIdentity.Blood) || 
          (player.Class == ClassIndentity.DemonHunter && player.Spec == SpecializationIdentity.Vengeance) || 
          (player.Class == ClassIndentity.Evoker && player.Spec == SpecializationIdentity.Augmentation) ||           
          (player.Class == ClassIndentity.Mage && player.Spec == SpecializationIdentity.Fire) || 
          (player.Class == ClassIndentity.Priest && player.Spec == SpecializationIdentity.Holy) ||
          player.Class == ClassIndentity.Rogue
        ) 
      },

      { "Blessing of Spellwarding", request.Players.Count(player => player.Class == ClassIndentity.Paladin && player.Spec == SpecializationIdentity.Protection) },
    };

    return await Task.FromResult(result);
  }
}
