using Microsoft.Extensions.DependencyInjection;

namespace RaidPlanner.Application;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
  {
    return serviceCollection;
  }
}
