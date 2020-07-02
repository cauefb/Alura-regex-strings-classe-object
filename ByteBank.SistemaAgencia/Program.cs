using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("3385557899");

            string contaToString = conta.ToString();
            
            Console.WriteLine("resultado "+ contaToString);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "designer";


            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "designer";

            if (carlos_1.Equals( carlos_2))
            {
                Console.WriteLine("São igauis");
            }
            else
            {
                Console.WriteLine("Sao diferentes");
            }

            Console.ReadLine();

        }

        static void testaString()
        {
            string padrao =
    "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);





            Console.ReadLine();
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("bytebank"));






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
            Console.WriteLine(termoBusca);



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
