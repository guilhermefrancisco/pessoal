using Record_Types;
using System;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {    
            Cliente cliente = new Cliente { Nome = "Guilherme", Email = "guilherme.francisco@gmail.com.br" };

            // -> Nova forma de cópia com a expressão -> With <-
            Cliente novoCliente = cliente with { Email = "guilherme@gmail.com.br" };

            // false
            Console.WriteLine(cliente == novoCliente);

            Cliente outroCliente = novoCliente with { Email = "guilherme.francisco@gmail.com.br" };

            // true
            Console.WriteLine(cliente == outroCliente);

            Console.ReadLine();

        }
    }
}
