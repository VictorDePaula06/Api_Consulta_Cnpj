using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsultaCnpj.Models
{
    public class Estabelecimento
    {
        [Newtonsoft.Json.JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [Newtonsoft.Json.JsonProperty("situacao_cadastral")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("inscricoes_estaduais")]
        public List<InscricaoEstadualDto> InscricaoEstaduais { get; set; }


    }
}