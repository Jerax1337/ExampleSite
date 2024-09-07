using Example.Logic.Interfaces.Repositories;
using Example.Logic.Interfaces.Services;
using Example.Logic.Repositories;
using Example.Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Logic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLogicServices(this IServiceCollection services)
        {
            services.AddSingleton<ICenterService, CenterService>();
			services.AddSingleton<IUserService, UserService>();

			services.AddSingleton<ICenterRepository, CenterRepository>();
			services.AddSingleton<IUserRepository, UserRepository>();
		}
    }
}
