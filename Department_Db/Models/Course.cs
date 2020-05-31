using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Department_Db.Models
{
    [JsonObject]
    public class Course
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("info")]
        public CourseInfo Info { get; set; }

        [JsonProperty("staff")]
        public Staff Staff { get; set; }
    }
}
