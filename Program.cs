using System;

namespace Faisp.OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo Recisão!");
            Console.WriteLine("Informe a data de contratação (dd/MM/aaaa): ");            
            var dataContratacao = Console.ReadLine();

            DateTime dataContratacaoConvertida;

            var converteu = DateTime.TryParse(dataContratacao, out dataContratacaoConvertida);

            if(converteu == true)
            {
                Console.WriteLine("Você informou a data: {0}", dataContratacao);
            }

            else
            {
                Console.WriteLine("Data inválida!");
            }
            Console.ReadKey();
        }
    }   

}
