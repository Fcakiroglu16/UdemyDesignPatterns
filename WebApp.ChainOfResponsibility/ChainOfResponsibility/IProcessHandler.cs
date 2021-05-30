using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ChainOfResponsibility.ChainOfResponsibility
{
    public interface IProcessHandler
    {
        IProcessHandler SetNext(IProcessHandler processHandler);

        Object handle(Object o);
    }
}