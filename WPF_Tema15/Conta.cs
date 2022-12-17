using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Tema15
{
    class Conta
    {
        private string numero;
        private string agencia;
        private double saldo;
        
        public void SetNumero(string num)
        {
            this.numero = num;
        }
        public void SetAgencia(string age)
        {
            this.agencia = age;
        }
        public void SetSaldo(double sal)
        {
            this.saldo = sal; 
        }
        public string GetNumero()
        {
            return numero; 
        }
        public string GetAgencia()
        {
            return agencia;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            return $"Número = {numero}, Agência = {agencia}, Saldo = R$ {saldo:0.00}";
        }
    }
}
