using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace AtiviadesPOO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            String Nome;
            double Saldo = 0;
            char deposito, teste;

            Console.Write("Entre o numero da conta: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            deposito = Convert.ToChar(Console.ReadLine());

            Char.ToUpper(deposito);

            ContaBancaria Conta;

            if (deposito == 'S')
            {
                Console.Write("Entre o valor de depósito inicial da conta: ");
                Saldo = Convert.ToDouble(Console.ReadLine());
                Conta = new ContaBancaria(Numero, Nome, Saldo);
            }
            else
            {
                Conta = new ContaBancaria(Numero, Nome, Saldo);
            }

            Console.WriteLine(Conta);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double Aux = Convert.ToDouble(Console.ReadLine());
            Conta.Deposito(Aux);

            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.Write("Entre um valor para saque: ");
            double Aux1 = Convert.ToDouble(Console.ReadLine());
            Conta.Saque(Aux);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.ReadKey();
            Console.Beep();
        }
    }
}