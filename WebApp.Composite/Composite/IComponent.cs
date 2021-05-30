using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Composite.Composite
{
    public interface IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        int Count();

        string Display();
    }
}