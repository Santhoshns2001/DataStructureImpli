using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndsDataStructureApril0104.StackImpli
{
    internal class StackByArray
    {

        private Object[] obj;
        public int size { get; private set; }
        int top;

        public StackByArray(int size)
        {
            this.size = size;
            obj=new object[size];
            top = -1;
        }

        public void Push(Object data)
        {
            if (top == size - 1)
            {
                Console.WriteLine("stack is overflow");
            }
            else
            {
                top=top + 1;
                obj[top] = data;
            }
        }

        public Object Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack is underflow");
                return null;
            }
                
           
            return obj[top--];
           
        }

        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("the stack is empty");
            }

            Console.WriteLine("the top element in the stack is "+obj[top]);

        }
        public void Display()
        {
            for(var i = top; i >= 0; i--)
            {
                Console.WriteLine(obj[i]);
            }
           
        }

}
}
