using Microsoft.Extensions.DependencyInjection;

namespace RaidPlanner.Infrastructure;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
  {
    return serviceCollection;
  }
}
