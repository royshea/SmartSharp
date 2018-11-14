namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class UninstallRequest : ExecutionRequest
    {
        [JsonProperty("uninstallData")]
        public InstalledApp UninstallData { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string, string> Settings { get; set; }
    }

    public class UninstallResponse
    {
        [JsonProperty("uninstallData")]
        public Object UninstallData { get; set; }
    }
}
