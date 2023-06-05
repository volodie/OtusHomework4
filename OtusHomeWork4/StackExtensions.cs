using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork4
{
    public static class StackExtensions
    {
        public static StackClass Merge(this StackClass stack1, StackClass stack2)
        {
            if (stack2.IsEmpty == false)
            {
                int sizeStack = stack2.Size();

                for (int i = 0; i <= sizeStack - 1; i++)
                {
                    stack1.Add(stack2.Pop());
                }
            }
        return stack1;
        }
    }
}
