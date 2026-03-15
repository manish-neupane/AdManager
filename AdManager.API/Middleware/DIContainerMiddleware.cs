using AdManager.DataAccess;
using AdManager.Interface.Application.Inventory;
using AdManager.Service.Application.Inventory;

namespace AdManager.API.Middleware
{
    public static class DIContainerMiddleware
    {
        public static IServiceCollection AppCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IDataAccessService, DataAccessService>();
            services.AddScoped<IScreenService, ScreenService>();
            return services;
        }
    }
}
