using DataAccess.IOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IOC
{
    public class ServicesContainer
    {
        public static IServiceCollection Configure(IServiceCollection services, IConfiguration configuration)
        {
            DataAccessContainer.Configure(services, configuration);

            services.AddTransient<IUserService, UserService>();
            return services;
        }
    }
}
