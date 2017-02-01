﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HueLib2
{
    /// <summary>
    /// Hue Tap Sensor State.
    /// </summary>
    [DataContract]
    class HueDimmerSensorState : SensorState
    {
        /// <summary>
        /// Button event number.
        /// </summary>
        [JsonIgnore]
        [DataMember]
        public int? buttonevent { get; set; }
    }
}
