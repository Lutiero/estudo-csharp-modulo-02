using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitebank
{
    internal class ContaCorrente
    {
        public int agencia;
        public string conta;        
        public Cliente titular;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if(valor > this.saldo)
            {
                return false;
            }

            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }


    }


}
