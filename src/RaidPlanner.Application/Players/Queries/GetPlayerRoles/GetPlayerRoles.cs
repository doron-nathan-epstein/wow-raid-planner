using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;
using System.Reflection.Emit;

namespace RaidPlanner.Application.Players.Queries.GetPlayerRoles;

public record GetPlayerRolesQuery : IRequest<IDictionary<string, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerRolesQueryHandler : IRequestHandler<GetPlayerRolesQuery, IDictionary<string, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<string, int>> Handle(GetPlayerRolesQuery request, CancellationToken cancellationToken)
  {
    var tank = 0;
    var melee = 0;
    var range = 0;
    var healer = 0;
    var support = 0;

    foreach (var player in request.Players)
    {
      foreach (var character in player.Characters.Where(character => character.IsMain))
      {
        var playerClass = _classes.First(c => c.Indentity == character.Class);
        var mainSpec = playerClass.Specializations.First(s => s.Indentity == character.MainSpec);

        switch (mainSpec.Role)
        {
          case Role.Tank:
            tank++;
            break;
          case Role.Melee:
            melee++;
            break;
          case Role.Range:
            range++;
            break;
          case Role.Healer:
            healer++;
            break;
          case Role.Support:
            support++;
            break;
        }
      }
    }

    var result = new Dictionary<string, int>
    {
      { "Tank", tank },
      { "Melee DPS", melee },
      { "Range DPS", range },
      { "Healer", healer },
      { "Support", support }
    };

    return await Task.FromResult(result);
  }
}
