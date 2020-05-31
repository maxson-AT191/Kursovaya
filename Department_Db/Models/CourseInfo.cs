using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Db.Models
{
    [JsonObject]
    public class CourseInfo
    {
        [JsonProperty("groups")]
        public Group[] Groups { get; set; }

        [JsonProperty("hours")]
        public int[] Hours { get; set; } = new int[3];
    }
}
