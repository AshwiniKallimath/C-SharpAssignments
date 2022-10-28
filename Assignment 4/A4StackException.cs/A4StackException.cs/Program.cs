using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4StackException

{
    public class StackException
    {
        public void Main()
        {
            throw new StackOverflowException("Oops! Stack is full");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n,i;
                Stack<int> st = new Stack<int>();
                Console.WriteLine("How many elements you want to enter:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter elements:");
                
                for(i=0;i<n;i++)
                {
                      st.Push(n);
                      Console.ReadLine();
                }
                Console.ReadKey();
            }
            catch (Exception StackException)
            {
                Console.WriteLine();
            }
    }
    
}



