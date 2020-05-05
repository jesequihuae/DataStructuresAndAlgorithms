using System;
using System.Collections.Generic;

namespace HackerRank.Algoritmos
{
    class Calculator
    {
        static Stack<string> operators = new Stack<string>();
        static Stack<double> operands = new Stack<double>();

        public static void Main3(String[] args)
        {
            String operation = Console.ReadLine();
            for (int i = 0; i < operation.Length; i++)
                addToStack(operation.Substring(i, 1));

            if(operands.Count > 0)
                Console.WriteLine(operands.Pop());

            Console.ReadKey();
        }

        public static void addToStack(string item)
        {
            if (item.Equals("(")) { }
            else if (item.Equals("+")) operators.Push(item);
            else if (item.Equals("-")) operators.Push(item);
            else if (item.Equals("*")) operators.Push(item);
            else if (item.Equals("/")) operators.Push(item);
            else if (item.Equals(")"))
            {
                string op = operators.Pop();
                double v = operands.Pop();

                if (op.Equals("+")) v = operands.Pop() + v;
                else if (op.Equals("-")) v = operands.Pop() - v;
                else if (op.Equals("*")) v = operands.Pop() * v;
                else if (op.Equals("/")) v = operands.Pop() / v;
                operands.Push(v);
            }
            else
                operands.Push(Double.Parse(item));
        }
    }
}
