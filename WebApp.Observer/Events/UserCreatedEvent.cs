using BaseProject.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Observer.Events
{
    public class UserCreatedEvent : INotification
    {
        public AppUser AppUser { get; set; }
    }
}