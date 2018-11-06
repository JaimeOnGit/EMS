using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EMS.Models
{
    public class Document
    {
        [JsonProperty(PropertyName = "docType")]
        public string DocType { get; set; }

        [JsonProperty(PropertyName ="uploadDate")]
        public DateTime UploadDate { get; set; }

        [JsonProperty(PropertyName ="URL")]
        public Uri Uri { get; set; }

    }
}