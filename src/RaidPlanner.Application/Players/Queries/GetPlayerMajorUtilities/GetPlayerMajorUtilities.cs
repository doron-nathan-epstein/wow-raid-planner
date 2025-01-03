using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMajorUtilities;

public record GetPlayerMajorUtilitiesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerMajorUtilitiesQueryHandler : IRequestHandler<GetPlayerMajorUtilitiesQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerMajorUtilitiesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Bloodlust", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Mage || character.Class == ClassIndentity.Evoker || character.Class == ClassIndentity.Shaman))) },
      { "Combat Res", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.DeathKnight || character.Class == ClassIndentity.Druid || character.Class == ClassIndentity.Paladin || character.Class == ClassIndentity.Warlock))) },
      { "Burst Move Speed", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Druid || character.Class == ClassIndentity.Shaman))) },
      { "Lock Stuff (HS, Gate, Curse)", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Warlock)) },
      { "Mass Dispel", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Monk || character.Class == ClassIndentity.Priest))) },
      { "Innervate", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Druid)) },
      { "Death Grip", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.DeathKnight)) },
      { "Blessing of Protection", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Paladin)) },
      { "Rallying Cry", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Warrior)) },
      { "Darkness", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.DemonHunter)) },
      { "Immunities", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Hunter || character.Class == ClassIndentity.Mage || character.Class == ClassIndentity.Paladin))) },
      { "Windfury", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.MainSpec == SpecializationIdentity.Enhancement)) },
      { "Boss DR", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Rogue)) },
      { "Dragons", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Evoker)) },
      { "Execute Damage", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Hunter || character.Class == ClassIndentity.Paladin || character.Class == ClassIndentity.Priest || character.Class == ClassIndentity.Warrior || character.MainSpec == SpecializationIdentity.Assassination && character.MainSpec == SpecializationIdentity.Fire))) },
      { "Attack Speed Reduction", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.DeathKnight || character.Class == ClassIndentity.Rogue || character.Class == ClassIndentity.Warlock))) },
      { "Cast Speed Reduction", request.Players.Count(player => player.Characters.Any(character => character.IsMain && (character.Class == ClassIndentity.Rogue || character.Class == ClassIndentity.Warlock))) },
      { "Skyfury", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Shaman)) },
    };

    return await Task.FromResult(result);
  }
}
