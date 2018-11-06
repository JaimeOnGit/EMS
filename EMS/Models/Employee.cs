using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EMS.Models
{
    public class Employee
    {
        [JsonProperty(PropertyName ="id")]
        public int id { get; set; }

        [JsonProperty(PropertyName ="firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        [JsonProperty(PropertyName = "firstSurname")]
        public string FirstSurname { get; set; }

        [JsonProperty(PropertyName = "secondSurname")]
        public string SecondSurname { get; set; }

        [JsonProperty(PropertyName = "DOB")]
        public DateTime DateOfBirth { get; set; }
                
        [JsonProperty(PropertyName ="documents")]
        public List<Document>EmployeeDocuments{ get; set; }

                          
    }
}