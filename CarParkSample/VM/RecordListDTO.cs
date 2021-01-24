using CarParkSample.VM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class RecordListDTO
    {

        [JsonProperty("value")]
        public List<RecordDTO> recordlist { get; set; }


    }




}
