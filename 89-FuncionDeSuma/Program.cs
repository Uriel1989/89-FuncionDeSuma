using System;

//Crea una función que sume dos números pasados por parámetros, devolverá el resultado.

namespace _89_FuncionDeSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion mat = new Operacion();

            int resultado = mat.suma(15, 35);

            Console.WriteLine(resultado);


        }
    }
}
