namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class UpdateRequest : ExecutionRequest
    {
        [JsonProperty("updateData")]
        public UpdateData UpdateData { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string, string> Settings { get; set; }
    }

    public class UpdateData
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("installedApp")]
        public InstalledApp InstalledApp { get; set; }

        [JsonProperty("previousConfig")]
        public Dictionary<string, List<Config>> PreviousConfig { get; set; }

        [JsonProperty("previousPermissions")]
        public List<string> PreviousPermissions { get; set; }
    }

    public class UpdateResponse
    {
        [JsonProperty("installData")]
        public Object UpdateData { get; set; }
    }
}
