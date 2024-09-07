using Example.Features.Interfaces.Managers;
using Example.Features.Managers;
using Example.Storage.Models;
using Example.Logic.Extensions;

namespace Example.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddWebServices(this IServiceCollection services)
        {
            services.AddLogicServices();

            services.AddTransient<ICenterManager, CenterManager>();
        }
    }
}
