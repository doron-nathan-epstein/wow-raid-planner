using MediatR;
using RaidPlanner.Domain.Entities;

namespace RaidPlanner.Application.Classes.Queries.GetClasses;

public record GetClassesQuery : IRequest<IEnumerable<Class>>;

internal class GetClassesQueryHandler : IRequestHandler<GetClassesQuery, IEnumerable<Class>>
{
  public async Task<IEnumerable<Class>> Handle(GetClassesQuery request, CancellationToken cancellationToken)
  {
    return await Task.FromResult(Domain.Constants.Classes.Get());
  }
}
