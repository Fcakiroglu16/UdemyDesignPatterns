using BaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Observer.Observer
{
    internal interface IUserObserver
    {
        void CreateUser(AppUser appUser);
    }
}