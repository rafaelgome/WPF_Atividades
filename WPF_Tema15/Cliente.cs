using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Tema15
{
    class Cliente
    {
        private string nome, cpf;
        private Conta[] contas = new Conta[5];
        private double saldoTotal; 
        private int k = 0;

        public void SetNome(string nom)
        {
            this.nome = nom; 
        }
        public void SetCpf(string scpf)
        {
            this.cpf = scpf; 
        }
        public void Inserir(Conta c)
        {
            contas[k] = c;
            k++;
        }
        public Conta[] Listar()
        {
            Conta[] vetor = new Conta[k];
            Array.Copy(contas, vetor, k);
            return vetor;

        }
        public double SaldoTotal(double aux)
        {
            saldoTotal += aux;
            return saldoTotal; 
        }
        public override string ToString()
        {
            return $"O saldo total do cliente {nome}, de CPF {cpf}, é R$ {saldoTotal:0.00}";
        }
    }
}
