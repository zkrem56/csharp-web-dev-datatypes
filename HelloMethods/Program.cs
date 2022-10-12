using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("ge");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
