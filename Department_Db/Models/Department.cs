using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Db.Models
{
    [JsonObject]
    public class Department
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("head")]
        public string Head { get; set; }

        [JsonProperty("cources")]
        public Course[] Cources { get; set; }

        [JsonProperty("depstaff")]
        public Staff DepartureStaff { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
