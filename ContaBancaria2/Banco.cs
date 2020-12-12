using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class Banco
    {        //Leticia Sorrilha de Souza.
        public Conta ContaBancaria { get; set; }

        public void LimitarSaque(double limite) 
        {
            ContaBancaria.LimiteDeSaque = limite;
        }

        public void Depositar(double quantia)
        {
            ContaBancaria.Saldo += quantia;
        }

        public void Sacar(double quantSaque)
        {
            if (quantSaque < ContaBancaria.LimiteDeSaque)
            {
                if (ContaBancaria.Saldo > 0)
                {
                    ContaBancaria.Saldo -= quantSaque;
                    Console.WriteLine("Saque realizado com Sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }

            } else
            {
                Console.WriteLine("Valor a ser sacado é superior ao Limite de Saque da Conta");
            }

            
            

        }
    }
}
