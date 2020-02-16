using Refit;
using System;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // static void Main(string[] args)
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu Cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando Informações do CEP: " + cepInformado);

                var adress = await cepCliente.GetAddressAsync(cepInformado);

                Console.WriteLine($"\nLogradouro:{adress.Logradouro}, \nBairro:{adress.Bairro}, \nUF`:{adress.UF}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e);
            }
        }
    }
}
