using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Db.Models
{
    [JsonObject]
    public class Group
    {
        [JsonProperty("specialty")]
        public string Specialty { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
