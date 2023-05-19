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
        public int agencia;
        public string conta;
        public Cliente titular;
        private double saldo = 100;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor > saldo)
            {
                return false;
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }


    }


}
