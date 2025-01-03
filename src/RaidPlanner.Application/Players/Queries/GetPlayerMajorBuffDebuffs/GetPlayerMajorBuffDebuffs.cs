using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerMajorBuffDebuffs;

public record GetPlayerRolesGetPlayerMajorBuffDebuffsQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerRolesGetPlayerMajorBuffDebuffsQueryHandler : IRequestHandler<GetPlayerRolesGetPlayerMajorBuffDebuffsQuery, IDictionary<string, int>>
{
  public async Task<IDictionary<string, int>> Handle(GetPlayerRolesGetPlayerMajorBuffDebuffsQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Intellect", request.Players.Count(player => player.Class == ClassIndentity.Mage) },
      { "Attack Power", request.Players.Count(player => player.Class == ClassIndentity.Warrior) },
      { "Stamina", request.Players.Count(player => player.Class == ClassIndentity.Priest) },
      { "3% DR (Devo Aura)", request.Players.Count(player => player.Class == ClassIndentity.Paladin) },
      { "5% Physical", request.Players.Count(player => player.Class == ClassIndentity.Monk) },
      { "5% Magic", request.Players.Count(player => player.Class == ClassIndentity.DemonHunter) },
      { "3% Versatility", request.Players.Count(player => player.Class == ClassIndentity.Druid) },
    };

    return await Task.FromResult(result);
  }
}
