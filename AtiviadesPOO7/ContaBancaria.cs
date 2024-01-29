using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiviadesPOO7
{
    class ContaBancaria
    {

        public int Numero { get; private set; }
        public String NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int Numero, String NomeTitular)
        {
            this.Numero = Numero;
            this.NomeTitular = NomeTitular;
        }
        public ContaBancaria(int Numero, String NomeTitular, Double Saldo) : this( Numero , NomeTitular )
        {
            Deposito(Saldo);
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor + 5;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {NomeTitular}, Saldo: ${Saldo.ToString("F2")}";
        }
    }
}
