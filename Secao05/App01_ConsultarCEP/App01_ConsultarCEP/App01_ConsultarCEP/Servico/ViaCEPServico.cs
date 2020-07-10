using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            try
            {
                string NovoEnderecoURL = string.Format(EnderecoURL, cep);
                WebClient wc = new WebClient();
                string conteudo = wc.DownloadString(NovoEnderecoURL);
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.Culture = new System.Globalization.CultureInfo("pt-BR");
                Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo, settings);
                if (end.cep == null) return null;
                    return end;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
