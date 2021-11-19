using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "123456";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль:");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.WriteLine("Секретное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine("У вас осталось " + (tryCount - i) + " попыток.");
                }
            }
            Console.ReadLine();

        }
    }
}
