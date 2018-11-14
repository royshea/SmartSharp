namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class InstalledApp
    {
        [JsonProperty("installedAppId")]
        public string InstalledAppId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("config")]
        public Dictionary<string, List<Config>> Config { get; set; }

        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
    }
}
