using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SYST_hw2_kurs_valyt_async
{
    public class Currency
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name_kaz")]
        public string NameKaz { get; set; }
        [JsonProperty("edinica_izmerenia")]
        public string EdinicaIzmerenia { get; set; }
        [JsonProperty("sootnowenie")]
        public string Sootnowenie { get; set; }
        [JsonProperty("name_rus")]
        public string NameRus { get; set; }
        [JsonProperty("kurs")]
        public string Kurs { get; set; }
        [JsonProperty("kod")]
        public string Kod { get; set; }
    }
}
