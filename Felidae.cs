using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
    public interface IFelidae 
    {
        int MaxSpeed { get; set; }
            
        public abstract void Hunting();

    }
}
