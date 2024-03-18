using System.Collections;
using System.Reflection.Metadata;

namespace ConsoleApp6
{
    public class Stack { 
      private ArrayList _stack= new ArrayList();

     
        public void Push(object obj) { 

            if (obj==null) 
                throw new InvalidOperationException("Cant be null!");
            
           _stack.Add(obj);
        }

        public void Pop()
        {
            if (_stack.Count == 0) 
                throw new InvalidOperationException("Empty stack!");
            

            var element = _stack[_stack.Count-1];
            Console.WriteLine(element);
            _stack.RemoveAt(_stack.Count - 1);

        }

        public void Clear()
        {
            _stack.Clear();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            
            stack.Pop();
            stack.Pop();
            stack.Pop();

        }
    }
}