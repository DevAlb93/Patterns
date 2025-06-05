using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Refactor_Polymorphism.NewVersion
{
    public class RegularCustomer : ICustomer
    {
        public double CalculateDiscount()
        {
            return 0.1;
        }
    }
}
