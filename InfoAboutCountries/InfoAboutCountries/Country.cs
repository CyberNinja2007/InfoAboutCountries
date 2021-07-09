using System.Collections.Generic;
using Newtonsoft.Json;

namespace InfoAboutCountries
{
    public class Country
    {
        public string name { get; set; }
        [JsonIgnore]
        public IList<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        [JsonIgnore]
        public string alpha3Code { get; set; }
        [JsonIgnore]
        public IList<string> callingCodes { get; set; }
        public string capital { get; set; }
        [JsonIgnore]
        public IList<string> altSpellings { get; set; }
        public string region { get; set; }
        [JsonIgnore]
        public string subregion { get; set; }
        public int population { get; set; }
        [JsonIgnore]
        public IList<double> latlng { get; set; }
        [JsonIgnore]
        public string demonym { get; set; }
        public double area { get; set; }
        [JsonIgnore]
        public double gini { get; set; }
        [JsonIgnore]
        public IList<string> timezones { get; set; }
        [JsonIgnore]
        public IList<string> borders { get; set; }
        [JsonIgnore]
        public string nativeName { get; set; }
        [JsonIgnore]
        public string numericCode { get; set; }
        [JsonIgnore]
        public IList<Currency> currencies { get; set; }
        [JsonIgnore]
        public IList<Language> languages { get; set; }
        [JsonIgnore]
        public Translations translations { get; set; }
        [JsonIgnore]
        public string flag { get; set; }
        [JsonIgnore]
        public IList<object> regionalBlocs { get; set; }
        [JsonIgnore]
        public string cioc { get; set; }
    }
}