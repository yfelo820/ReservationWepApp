using Microsoft.Extensions.DependencyInjection;
using ReservationWepApp.BackStaff.Interfaces;
using ReservationWepApp.BackStaff.Repository;
using ReservationWepApp.BackStaff.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.Middleware
{
    public static class IoC
    {

        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReservationRepository<>), typeof(ReservationRepository<>));
            services.AddTransient<IMasterService, MasterService>();
            return services;

        }

    }
}
