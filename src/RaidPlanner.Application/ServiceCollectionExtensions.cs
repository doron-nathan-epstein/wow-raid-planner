using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RaidPlanner.Application;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
  {
    serviceCollection.AddMediatR(cfg =>
    {
      cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    });

    return serviceCollection;
  }
}
