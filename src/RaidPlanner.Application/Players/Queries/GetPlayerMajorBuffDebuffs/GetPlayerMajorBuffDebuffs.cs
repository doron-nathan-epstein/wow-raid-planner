using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMajorBuffDebuffs;

public record GetPlayerRolesGetPlayerMajorBuffDebuffsQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerRolesGetPlayerMajorBuffDebuffsQueryHandler : IRequestHandler<GetPlayerRolesGetPlayerMajorBuffDebuffsQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerRolesGetPlayerMajorBuffDebuffsQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Intellect", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Mage)) },
      { "Attack Power", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Warrior)) },
      { "Stamina", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Priest)) },
      { "3% DR (Devo Aura)", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Paladin)) },
      { "5% Physical", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Monk)) },
      { "5% Magic", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.DemonHunter)) },
      { "3% Versatility", request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == ClassIndentity.Druid)) },
    };

    return await Task.FromResult(result);
  }
}
