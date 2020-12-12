using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class Program
    {         //Leticia Sorrilha de Souza.
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.ContaBancaria = CriarConta();
            banco.LimitarSaque(500.00);
            banco.Depositar(InputDeposito());
            banco.Sacar(InputSaque());
            Console.ReadLine();
            

        }
        public static Conta CriarConta()
        {
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Entre com o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            return new Conta(numero, titular, saldo);
        }

        public static double InputDeposito()
        {
            Console.Write("Por favor, entre com valor a ser depositado!");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            return deposito;
        }

        public static double InputSaque()
        {
            Console.Write("Por favor, entre com valor a ser sacado!");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return saque;
        }
    }
}
