using Adp.Test.Core.Interfaces;
using Adp.Test.Core.Services;

namespace Adp.Test.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
