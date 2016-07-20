using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesDemo.Models
{
    public class GeolocationModel
    {
        public Geolocation Geolocation { get; set; }   
    }


    public class Geolocation
    {
        public string State { get; set; }
    }
}
