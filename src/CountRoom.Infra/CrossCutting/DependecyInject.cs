using CountRoom.Core.Bus;
using CountRoom.Core.CommandHandlers;
using CountRoom.Infra.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CountRoom.Infra.CrossCutting
{
    public static class DependecyInject
    {
        public static void ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IBus, MediatorBus>();

            services.AddScoped<VerifyFlowRoomCommandHandler>();

            services.AddMediatR();
        }
    }
}