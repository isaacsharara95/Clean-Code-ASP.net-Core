using HR.LeaveManagement.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HR.LeaveManagement.Application
{
   public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());   //will traverse through all the mapping profiles
                                                                       //services.AddAutoMapper(typeof(MappingProfile));         //Could be use for each and every mapping profile that inherits from Profile class

            return services;

        }
    }
}
