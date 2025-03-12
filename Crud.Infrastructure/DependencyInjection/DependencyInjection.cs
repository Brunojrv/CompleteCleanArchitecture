using Crud.Domain.AggregateRoot;
using Crud.Domain.Interface.Patient;
using Crud.Domain.Interface.Repositories;
using Crud.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //Singleton
            services.AddSingleton<IRepositories, MongoRepository>();

            //Transient 
            services.AddTransient<IPatient, Patient>();

            return services;
        }
    }
}
