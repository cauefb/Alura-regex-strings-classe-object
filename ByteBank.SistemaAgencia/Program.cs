using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine( urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();




            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedadestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();


            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToUpper());
            Console.WriteLine(termoBusca.ToUpper());

            //testando replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca );

            

            // pagina?argumentos
            // 012345678
  

           

            //testando metodo remove
            //string testeRemocao = "primeiraParte&parteParRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial,4));
            //Console.ReadLine();

            string palavra = "moedaOrigen=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            
            Console.WriteLine(indice);
            Console.WriteLine("Tamanho da string nomeArgumento : " + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
       


            //testando isNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));

            string url = "";

            int indiceInterrogacao = url.LastIndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

         
      

            
        }
    }


}
