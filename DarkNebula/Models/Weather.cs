using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DarkNebula.Models
{
    [Serializable()]
    public class Weather
    {


        [System.Xml.Serialization.XmlElement("City")]
        public string City { get; set; }
        [System.Xml.Serialization.XmlElement("PostalCode")]
        public string PostalCode { get; set; }
        [System.Xml.Serialization.XmlElement("ForecastDate")]
        public DateTime ForecastDate { get; set; }
        [System.Xml.Serialization.XmlElement("CurrentDateTime")]
        public DateTime CurrentDateTime { get; set; }
        [System.Xml.Serialization.XmlElement("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }
    }
}