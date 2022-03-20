using sabirov.bars.task3.actions.Models;
using System;

namespace sabirov.bars.task3.actions
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.OnKeyPressed += TestClass_OnKeyPressed;
            testClass.OnError += TestClass_OnError;
            testClass.Run();
        }

        private static void TestClass_OnError(Exception obj)
        {
            Console.WriteLine($"Упс... ошибка {obj.Message}");
        }

        private static void TestClass_OnKeyPressed(object sender, char e)
        {
            Console.WriteLine(e);
        }
    }
}
