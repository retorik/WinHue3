﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HueLib2
{
    [DataContract]
    public class HueMotionSensorState : SensorState
    {
        [JsonIgnore]
        [DataMember]
        public bool? presence { get; set; }
    }
}
