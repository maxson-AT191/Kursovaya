using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Db.Models
{
    [JsonObject]
    public class DepartmentsDb
    {
        [JsonProperty("departments")]
        public Department[] Departments { get; set; }
    }
}
