using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Methods
{
    internal class A
    {
        public virtual int Add(int num1,int num2)
        {
            return (num1 + num2);
        }
    }
    class B : A
    {
        public override int Add(int num1, int num2)
        {
            return base.Add(num1, num2);
        }
    }
}
