using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL{ get;  }
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (String.IsNullOrEmpty(url))
            {

                throw new ArgumentException("O argumento url não pode ser nulo ou vazio. ",nameof(url));
            }

          
          
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao);
            URL = url;

      
        }
        //pagina?moedaOrigen=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "=";
            int indicetermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indicetermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

            return _argumentos.Substring(indicetermo + termo.Length);
            return "";
        }
    }
}
