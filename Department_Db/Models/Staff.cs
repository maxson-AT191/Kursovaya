using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Department_Db.Models
{
    [JsonObject]
    public class Staff
    {
        [JsonProperty("lecturers")]
        public string[] Lecturers { get; set; }

        [JsonProperty("assistants")]
        public string[] Assistants { get; set; }
    }
}
