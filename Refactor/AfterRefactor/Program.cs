using Microsoft.Extensions.DependencyInjection;
using Refactor.Framework;
namespace Refactor
{
    class Program
    {
        private static ServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            RegisterService();
            var userDto = ConsoleUser.GetUser();
            var user = new User(userDto);
            PersistanceUser(user);

        }

        private static void RegisterService()
        {
             serviceProvider = new ServiceCollection()
               .AddSingleton<IPersistanceUser, PersistanceUserSQL>()
               .AddSingleton<IPersistanceUser, PersistanceUserFile>()
               .BuildServiceProvider();
        }

        private static void PersistanceUser(User user)
        {
            var persistances = serviceProvider.GetServices<IPersistanceUser>();
            foreach (var persistance in persistances)
            {
                persistance.Save(user);
            }

        }
    }

    
}
