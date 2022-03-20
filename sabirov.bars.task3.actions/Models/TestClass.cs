using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sabirov.bars.task3.actions.Models
{
    public class TestClass
    {
        public event EventHandler<char> OnKeyPressed;
        public event Action<Exception> OnError;
        private static char exitSymbol = 'c';
        public void Run()
        {
            Console.WriteLine($"Здравствуйте! Чтобы выйти из цикла, необходимо ввести в консоль символ \"{exitSymbol}\".");
            while (true)
            {
                try
                {
                    var msg = Convert.ToChar(Console.ReadLine());
                    if (msg == exitSymbol)
                    {
                        OnKeyPressed.Invoke(this, msg);
                        Console.WriteLine("ну вот и все.. конец");
                        break;
                    }
                    Console.WriteLine($"это не символ \"{exitSymbol}\", жду следующего сообщения...");

                }
                catch (Exception e)
                {
                    OnError.Invoke(e);
                }

            }
        }
    }
}
