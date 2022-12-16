using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Tema15
{
    class Conta
    {
        private string numero, agencia;
        private double saldo;
        
        public void SetNumero(string num)
        {
            numero = num;
        }
        public void SetAgencia(string age)
        {
            agencia = age;
        }
        public void SetSaldo(double sal)
        {
            saldo = sal; 
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
            return $"Número = {numero}, Agência = {agencia}, Saldo = {saldo}";
        }
    }
}
