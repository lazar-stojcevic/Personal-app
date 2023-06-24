using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assemby = typeof(DependencyInjection).Assembly;

        services.AddMediatR(configuration =>
            configuration
            .RegisterServicesFromAssembly(assemby));

        services.AddValidatorsFromAssembly(assemby);

        return services;
    }
}
