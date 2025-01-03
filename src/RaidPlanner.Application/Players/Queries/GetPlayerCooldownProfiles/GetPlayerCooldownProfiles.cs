using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerCooldownProfiles;

public record GetPlayerCooldownProfilesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerCooldownProfilesQueryHandler : IRequestHandler<GetPlayerCooldownProfilesQuery, IDictionary<string, int>>
{
  public async Task<IDictionary<string, int>> Handle(GetPlayerCooldownProfilesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "1 and 1.5 min", request.Players.Count(player => 
          player.Spec == SpecializationIdentity.Enhancement ||
          player.Spec == SpecializationIdentity.Fury ||
          player.Spec == SpecializationIdentity.Retribution
        ) 
      },

      { "2 min", request.Players.Count(player => 
          player.Spec == SpecializationIdentity.Affliction || 
          player.Spec == SpecializationIdentity.Assassination || 
          player.Spec == SpecializationIdentity.Augmentation || 
          player.Spec == SpecializationIdentity.BeastMastery || 
          player.Spec == SpecializationIdentity.Demonology || 
          player.Spec == SpecializationIdentity.Destruction || 
          player.Spec == SpecializationIdentity.Devastation || 
          player.Spec == SpecializationIdentity.Feral || 
          player.Spec == SpecializationIdentity.Fire || 
          player.Spec == SpecializationIdentity.Havoc || 
          player.Spec == SpecializationIdentity.Marksmanship || 
          player.Spec == SpecializationIdentity.Shadow || 
          player.Spec == SpecializationIdentity.Subtlety ||
          player.Spec == SpecializationIdentity.Survival ||
          player.Spec == SpecializationIdentity.Windwalker
        ) 
      },

      { "3 min", request.Players.Count(player => 
          player.Spec == SpecializationIdentity.Balance || 
          player.Spec == SpecializationIdentity.Unholy ||
          player.Spec == SpecializationIdentity.Retribution
        ) 
      },
    };

    return await Task.FromResult(result);
  }
}
