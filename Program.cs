using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Informe o CEP: ");
            string cep = Console.ReadLine();


            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/"  + cep + "/json/");

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();



                Console.WriteLine(responseString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}


