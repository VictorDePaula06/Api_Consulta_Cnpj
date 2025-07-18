using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiConsultaCnpj.Models
{
    public class InscricaoEstadualDto
    {
        [JsonProperty("inscricao_estadual")]
        public string Numero { get; set; }

        [JsonProperty("ativo")]
        public bool Ativo { get; set; }

        [JsonProperty("estado")]
        public EstadoDto Estado { get; set; }
    }
}