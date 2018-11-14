namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class InstallRequest : ExecutionRequest
    {
        [JsonProperty("installData")]
        public InstallData InstallData { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string, string> Settings { get; set; }
    }

    public class InstallData
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("installedApp")]
        public InstalledApp InstalledApp { get; set; }
    }

    public class InstallResponse
    {
        [JsonProperty("installData")]
        public Object InstallData { get; set; }
    }
}
