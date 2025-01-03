using MediatR;
using RaidPlanner.Domain.Entities;
using RaidPlanner.Domain.Enums;

namespace RaidPlanner.Application.Players.Queries.GetPlayers;

public record GetPlayersQuery : IRequest<IEnumerable<Player>>;

internal class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, IEnumerable<Player>>
{
  public async Task<IEnumerable<Player>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
  {
    var result = new List<Player>
    {
      new() {
        Name = "Bean",
        Status = PlayerStatus.Confirmed,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Paladin,
            MainSpec = SpecializationIdentity.Protection,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Aequity",
        Status = PlayerStatus.Confirmed,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Mage,
            MainSpec = SpecializationIdentity.Frost,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Baneskeeper",
        Status = PlayerStatus.Confirmed,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Paladin,
            MainSpec = SpecializationIdentity.Retribution,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Lockheart",
        Status = PlayerStatus.Review,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Priest,
            MainSpec = SpecializationIdentity.Holy,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Meget",
        Status = PlayerStatus.Review,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Rogue,
            MainSpec = SpecializationIdentity.Assassination,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Meiko",
        Status = PlayerStatus.Review,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.DeathKnight,
            MainSpec = SpecializationIdentity.Unholy,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Moth",
        Status = PlayerStatus.Review,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Warlock,
            MainSpec = SpecializationIdentity.Destruction,
            IsMain = true
          }
        }
      },
      new() {
        Name = "Ninatuga",
        Status = PlayerStatus.Review,
        Characters = new List<Character>()
        {
          new() {
            Class = ClassIndentity.Hunter,
            MainSpec = SpecializationIdentity.Survival,
            IsMain = true
          }
        }
      }
    };

    return await Task.FromResult(result);
  }
}
