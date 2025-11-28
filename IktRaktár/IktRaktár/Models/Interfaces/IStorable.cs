using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IktRaktár.Models.Interfaces
{
    internal interface IStorable
    {
        string Name { get; }
        int Quantity { get; set; }
    }
}