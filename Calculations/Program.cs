namespace Calculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator
    { 
        public Calculator() 
        { 

        }

        public int Add(int value, int value2)
        {
           
            return value+value2;
        }
        public int subtract(int value, int value2)
        {
            return value-value2;
        }
        public float divide(int value, float divisor)
        {
            if (divisor == 0) { return value; };
            if (value == 0) { return (float)value; }

            return value/divisor;
        }
        public int multiply (int value, int value2) 
        { 
            return value*value2;
        }
        public int median(List<int> list)
        {
            list.Sort();
            return list[(int)divide(list.Count - 1, 2f)];
        }

    }





}