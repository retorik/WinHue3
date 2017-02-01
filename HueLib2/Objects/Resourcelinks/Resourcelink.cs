﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace HueLib2
{
    [DefaultProperty("Resource Links"), DataContract]
    public class Resourcelink : HueObject
    {
        private string _name;

        /// <summary>
        /// Name of the resource link
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"),
         Description("Name of the resource link")]
        public string name
        {
            get
            {
                return _name;
            }
            set { _name = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Description of the resource link
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("Description of the resource link")]
        public string description { get; set; }

        /// <summary>
        /// Type of Resource Link
        /// </summary>
        [JsonIgnore]
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("Type of the resource link")]
        public string type { get; set; }
        
        /// <summary>
        /// Class of the resource link
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("Class of the resource link"),CreateOnly]
        public ushort classid { get; set; }

        /// <summary>
        /// Owner of the resource link
        /// </summary>
        [JsonIgnore]
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("Owner of the resource link")]
        public string owner { get; set; }

        /// <summary>
        /// Owner of the resource link
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("Allow Recycle of the resource link"), CreateOnly]
        public bool? recycle { get; set; }

        /// <summary>
        /// List of resource links
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false), Category("Resource Link"), Description("List of resource links"), Browsable(false)]
        public List<string> links { get; set; }
    }
}
