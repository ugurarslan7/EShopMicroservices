using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ordering.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddAutoMapper(typeof(DependencyInjection).Assembly);
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        //services.AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<DependencyInjection>());
        return services;
    }
}
