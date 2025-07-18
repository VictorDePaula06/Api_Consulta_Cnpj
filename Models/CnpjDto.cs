using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsultaCnpj.Models
{
    public class CnpjDto
    {
        [Newtonsoft.Json.JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        [Newtonsoft.Json.JsonProperty("estabelecimento")]
        public Estabelecimento Estabelecimento { get; set; }

    }
}