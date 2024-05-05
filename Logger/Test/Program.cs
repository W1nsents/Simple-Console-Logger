using System;
using WLogger;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic.Install();

            Console.WriteLine("// Default");
            Basic.Info("This is the information text..");
            Basic.Warn("This is the warning text..");
            Basic.Error("This is the error text..");
            Basic.Debug("This is the debug text..");

            Console.WriteLine();

            Console.WriteLine("// Date Time = false");
            Basic.Info("This is the information text..", false);
            Basic.Warn("This is the warning text..", false);
            Basic.Error("This is the error text..", false);
            Basic.Debug("This is the debug text..", false);
            Console.ReadLine();
        }
    }
}
