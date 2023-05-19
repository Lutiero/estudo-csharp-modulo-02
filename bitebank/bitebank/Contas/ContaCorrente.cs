using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitebank.Titular;

namespace bitebank.Contas
{
    internal class ContaCorrente
    {
        private int agencia;
        private string conta;
        public Cliente Titular { get; set; }
        private double saldo = 100;

        public int Agencia
        {
            get { return agencia; }
            set { 
                if(value < 0)
                {
                    return;
                }
                agencia = value; 
            }
        }

        public string Conta{ get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            Saldo = valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > Saldo)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor > Saldo)
            {
                return false;
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }

    }


}
