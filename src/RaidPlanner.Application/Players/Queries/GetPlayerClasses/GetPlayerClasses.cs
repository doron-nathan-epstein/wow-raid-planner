using MediatR;
using RaidPlanner.Domain.Entities;

namespace RaidPlanner.Application.Players.Queries.GetPlayerClasses;

public record GetPlayerClassesQuery : IRequest<IDictionary<Class, int>>
{
  public IEnumerable<Player> Players { get; set; } = [];
}

internal class GetPlayerClassesQueryHandler : IRequestHandler<GetPlayerClassesQuery, IDictionary<Class, int>>
{
  private readonly IEnumerable<Class> _classes = Domain.Constants.Classes.Get();

  public async Task<IDictionary<Class, int>> Handle(GetPlayerClassesQuery request, CancellationToken cancellationToken)
  {
    var result = new Dictionary<Class, int>();
    foreach (var _class in _classes)
    {
      result.Add(_class, request.Players.Count(player => player.Characters.Any(character => character.IsMain && character.Class == _class.Indentity)));
    }

    return await Task.FromResult(result);
  }
}
