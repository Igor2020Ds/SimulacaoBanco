using System;
using System.Reflection.Metadata;

using System.Globalization;
using Program;



namespace IntefaceUsuario 
{

    class InterfaceUI
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Informe o numero da conta");
            int numeroConta= int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Titular da conta");
            string  titularConta=(Console.ReadLine());  

            Console.WriteLine("Haverá deposito inicial?");
            char respDepositoIni = char.Parse(Console.ReadLine());

            if (respDepositoIni == 's' || respDepositoIni =='S')
            {
                Console.WriteLine("Informe o valor do depósito inicial");
                double depositoInicialConta = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numeroConta,titularConta,depositoInicialConta); // chamando o construtor (instanciando)

            }

            else {
                conta = new ContaBancaria(numeroConta, titularConta);
            }


            Console.WriteLine("Dados da Conta : " + conta);

            Console.WriteLine("Digite 1 para realizar DEPÓSITO");
            int codigo = int.Parse(Console.ReadLine());
            
            if (codigo == 1)

            {

                Console.WriteLine("Infome o valor do DEPOSITO");
                double ValorDepositoInicial = double.Parse(Console.ReadLine());

            }

            else if(codigo == 2) {

                Console.WriteLine("Informe o valor do SAQUE");
            }

            else
            {
                Console.WriteLine("Còdigo incorreto, falha na Operação");
            }





        }

        

        
    }
}