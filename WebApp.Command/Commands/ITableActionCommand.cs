using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Command.Commands
{
    public interface ITableActionCommand
    {
        IActionResult Execute();
    }
}