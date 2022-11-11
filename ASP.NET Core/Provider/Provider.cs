using System;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer;
namespace Provider
{
    public static class Provider
    {
        public static IServiceCollection Get()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IGetUserDB>(new DBusers());
            services.AddSingleton<IGetUsersDB>(new DBusers());
            services.AddSingleton<IRegisterDB>(new DBusers());
            services.AddSingleton<IUpdateUserDB>(new DBusers());
            services.AddSingleton<IRegisterDB>(new DBusers());




            services.AddSingleton<ITournamentDB>(new TournamentDB());
            services.AddSingleton<IGameDB>(new GameDB());
            return services;
        }
    }
}
