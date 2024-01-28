using System;
using System.Linq.Expressions;

namespace ConsoleNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                //double x = null;  Não é possível realizar essa declaração
                Nullable<double> x = null; ///Permitido
                double? y = null;          ///Permitido      
                y = 10.0;
                Console.WriteLine("x é null" + x);
                Console.WriteLine("y é nullable" + y);
                Console.WriteLine(x.GetValueOrDefault());
                Console.WriteLine(y.GetValueOrDefault());
                Console.WriteLine(x.HasValue); // Property HasValue retorna True ou False caso tenha valor
                Console.WriteLine(y.HasValue);// Property HasValue retorna True ou False caso tenha valor
                if (x.HasValue)
                    Console.WriteLine(x.Value);
                else Console.WriteLine("X é Null");

                if (y.HasValue)
                    Console.WriteLine(y.Value);
                else
                    Console.WriteLine("Y é Null");

                // Operador de coalescência null
                y = x ?? 100;

                Console.WriteLine(y.Value); // No InvalidOperationException
            }
            catch (Exception e)
            {
                throw new ArgumentNullException(e.Message + e.Source, message: "Name cannot be null");
            }
        }
    }
}
