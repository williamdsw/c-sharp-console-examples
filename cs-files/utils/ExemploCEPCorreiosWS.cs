﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    /* https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl */

    class ExemploCEPCorreiosWS
    {
        public ExemploCEPCorreiosWS ()
        {
            string CEP = "13303502";

            /* WebService client */
            var client = new AtendeClienteService.AtendeClienteClient ();

            /* Retorno pesquisa */
            var result = client.consultaCEP (CEP);

            /* Campos */
            var data = new
            {
                bairro = result.bairro,
                cep = result.cep,
                cidade = result.cidade,
                complemento = result.complemento2,
                endereco = result.end,
                uf = result.uf
            };  

            string text = String.Format ("{0} - {1} - {2} - {3} - {4} - {5}", data.endereco, data.complemento, data.cep, data.bairro, data.cidade, data.uf);
            Console.WriteLine (text);
        }
    }
}
