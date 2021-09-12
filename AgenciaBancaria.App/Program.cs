using AgenciaBancaria.Dominio;
using System;


namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "3333330", "Belo Horizonte", "MG");
                Cliente cliente = new Cliente("Bruna", "123456", "780910", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ":" + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "1234ab";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ":" + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha );

                Console.WriteLine("Saldo:" + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
