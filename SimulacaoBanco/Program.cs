using System;
using System.Globalization;




namespace Program
{
    class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; set; }

        public double ValorDepositoInicial { get; set; }

        public double ValorDeposito { get; set; }

        public double ValorSaque { get; set; }

        public int Codigo { get; set; }

        // construtor com 2 argumentos
        public ContaBancaria(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaBancaria(int numeroConta, string titularConta, double saldoConta) : this(numeroConta, titularConta) // this reaproveita o contrutor
        {
            SaldoConta = saldoConta;
        }


        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

        public override string ToString() // prepara recebimento de conteúdo textual

            {
            return  " Conta "
        + NumeroConta
        + "  Titular :   "
        + TitularConta
        + "Saldo $ "
        + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
            }

        


    }
}