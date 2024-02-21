using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class ContaBancaria
    {
        /*Implemente uma classe chamada “ContaBancária” que possua atributos para armazenar o
        número da conta, nome do titular e saldo.Adicione métodos para realizar depósitos e
        saques.*/

        public int NumeroConta { get; set; }

        public string NomeTitular { get; set; }

        public decimal SaldoConta { get; set; }

        public ContaBancaria(int numeroConta, string nomeTitular, decimal saldoConta)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            SaldoConta = saldoConta;
        }

        public decimal DepositoBancario()
        {
            Console.WriteLine("Deposite um valor:");
            decimal depositar = decimal.Parse(Console.ReadLine());
            SaldoConta += depositar;
            Console.WriteLine($"Depósito de R${depositar} realizado com sucesso. Saldo atual da conta: {SaldoConta}."); 
            return depositar;
        }

        public decimal SaqueBancario()
        {
            Console.WriteLine("Digite o valor a ser sacado: ");
            decimal sacar = decimal.Parse(Console.ReadLine());
            SaldoConta -= sacar;
            Console.WriteLine($"Saque de R${sacar} realizado com sucesso. Saldo atual da conta: {SaldoConta}");
            return sacar;
        }

    }
}

