using BaseProject.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Observer.Observer
{
    public class UserObserverCreateDiscount : IUserObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public UserObserverCreateDiscount(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void UserCreated(AppUser appUser)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverCreateDiscount>>();

            using var scope = _serviceProvider.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<AppIdentityDbContext>();

            context.Discounts.Add(new Models.Discount { Rate = 10, UserId = appUser.Id });
            context.SaveChanges();
            logger.LogInformation("Discount created");
        }
    }
}