using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Programm
{
    internal class Program
    {
        static void Main()
        {
            Type type = typeof(ConsoleKeyInfo);
            Console.WriteLine("Значения методов:");
            foreach (MethodInfo methods in type.GetMethods())
            {
                Console.WriteLine("\n");
                Console.WriteLine(methods.Name);
                Console.WriteLine($"Абстрактный: {methods.IsAbstract}");
                Console.WriteLine($"Защищённый(protected)?: {methods.IsFamily}");
                Console.WriteLine($"Private Protected?: {methods.IsFamilyAndAssembly}");
                Console.WriteLine($"Protected Internal?: {methods.IsFamilyOrAssembly}");
                Console.WriteLine($"Internal?: {methods.IsAssembly}");
                Console.WriteLine($"Private?: {methods.IsPrivate}");
                Console.WriteLine($"Public?: {methods.IsPublic}");
                Console.WriteLine($"Конструктор?:{methods.IsConstructor}");
                Console.WriteLine($"Static?: {methods.IsStatic}");
                Console.WriteLine($"Virtual?: {methods.IsVirtual}");
                Console.WriteLine($"Тип: {methods.ReturnType}");
                
            }

        }
    }
}
