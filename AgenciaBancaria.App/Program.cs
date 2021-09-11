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

                ContaBancaria conta = new ContaBancaria(cliente);

                Console.WriteLine("Conta criada: " + conta.NumeroConta + "-" + conta.DigitoVerificador);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
