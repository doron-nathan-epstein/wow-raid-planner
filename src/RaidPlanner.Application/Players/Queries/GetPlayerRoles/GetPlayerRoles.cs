using MediatR;
using RaidPlanner.Application.Players.Queries.Common;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayerRoles;

public record GetPlayerRolesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<SimplePlayerDto> Players { get; set; } = [];
}

internal class GetPlayerRolesQueryHandler : IRequestHandler<GetPlayerRolesQuery, IDictionary<string, int>>
{
  public async Task<IDictionary<string, int>> Handle(GetPlayerRolesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<string, int>
    {
      { "Tank", request.Players.Count(player => player.Role == Role.Tank) },
      { "Melee DPS", request.Players.Count(player => player.Role == Role.Melee) },
      { "Range DPS", request.Players.Count(player => player.Role == Role.Range) },
      { "Healer", request.Players.Count(player => player.Role == Role.Healer) },
      { "Support", request.Players.Count(player => player.Role == Role.Support) }
    };

    return await Task.FromResult(result);
  }
}
