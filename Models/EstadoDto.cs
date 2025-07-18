using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiConsultaCnpj.Models
{
    public class EstadoDto
    {
        [JsonProperty("sigla")]
        public string Sigla { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        // [JsonProperty("id")]
        // public string Id { get; set; }
    }
}