using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите число типа long: ");
            string input = Console.ReadLine();

            // Проверка на пустой ввод
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ввод пуст. Программа завершена.");
                return;
            }

            // Безопасный парсинг: TryParse не выбросит исключение при некорректном вводе
            if (!long.TryParse(input, out long longVal))
            {
                Console.WriteLine("Ошибка: введено неверное число. Используйте только цифры (можно со знаком).");
                return;
            }

            // Проверка диапазона short
            if (longVal >= short.MinValue && longVal <= short.MaxValue)
            {
                Console.WriteLine("Число помещается в short.");
            }
            else
            {
                Console.WriteLine("Число НЕ помещается в short (переполнение).");
            }
        }
    }
}
