using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerCooldownProfiles;

public record GetPlayerCooldownProfilesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerCooldownProfilesQueryHandler : IRequestHandler<GetPlayerCooldownProfilesQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerCooldownProfilesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "1 and 1.5 min", request.Players.Count(player => player.Characters.Any(character => character.IsMain 
        && (character.MainSpec == SpecializationIdentity.Enhancement || 
        character.MainSpec == SpecializationIdentity.Fury || 
        character.MainSpec == SpecializationIdentity.Retribution))) },

      { "2 min", request.Players.Count(player => player.Characters.Any(character => character.IsMain 
        && (character.MainSpec == SpecializationIdentity.Affliction || 
        character.MainSpec == SpecializationIdentity.Assassination || 
        character.MainSpec == SpecializationIdentity.Augmentation || 
        character.MainSpec == SpecializationIdentity.BeastMastery || 
        character.MainSpec == SpecializationIdentity.Demonology || 
        character.MainSpec == SpecializationIdentity.Destruction || 
        character.MainSpec == SpecializationIdentity.Devastation || 
        character.MainSpec == SpecializationIdentity.Feral || 
        character.MainSpec == SpecializationIdentity.Fire || 
        character.MainSpec == SpecializationIdentity.Havoc || 
        character.MainSpec == SpecializationIdentity.Marksmanship || 
        character.MainSpec == SpecializationIdentity.Shadow || 
        character.MainSpec == SpecializationIdentity.Subtlety ||
        character.MainSpec == SpecializationIdentity.Survival || 
        character.MainSpec == SpecializationIdentity.Windwalker))) },

      { "3 min", request.Players.Count(player => player.Characters.Any(character => character.IsMain 
        && (character.MainSpec == SpecializationIdentity.Balance || 
        character.MainSpec == SpecializationIdentity.Unholy || 
        character.MainSpec == SpecializationIdentity.Retribution))) },
    };

    return await Task.FromResult(result);
  }
}
