namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Collections.Generic;
    using static Enums;

    public class ConfigurationRequest : ExecutionRequest
    {
        [JsonProperty("configurationData")]
        public ConfigurationData ConfigurationData { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string, string> Settings { get; set; }
    }

    public class ConfigurationData
    {
        [JsonProperty("installedAppId")]
        public string InstalledAppId { get; set; }

        [JsonProperty("phase")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PhaseEnum Phase { get; set; }

        [JsonProperty("pageId")]
        public string PageId { get; set; }

        [JsonProperty("previousPageId")]
        public string PreviousPageId { get; set; }

        [JsonProperty("config")]
        public Dictionary<string, List<Config>> Config { get; set; }

        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
    }

    public class ConfigurationInitResponse
    {
        [JsonProperty("configurationData")]
        public InitResponse ConfigInitResponse { get; set; }
    }

    public class InitResponse
    {
        [JsonProperty("initialize")]
        public Initialize Init { get; set; }
    }

    public class Initialize
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        // TODO: Some typing around these to provide structure
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        [JsonProperty("firstPageId")]
        public string FirstPageId { get; set; }
    }

    public class ConfigurationPageResponse
    {
        [JsonProperty("configurationData")]
        public PageResponse ConfigPageaResponse { get; set; }
    }

    public class PageResponse
    {
        [JsonProperty("page")]
        public Page Page { get; set; }
    }

    public class Page
    {
        [JsonProperty("pageId")]
        public string PageId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nextPageId")]
        public string NextPageId { get; set; }

        [JsonProperty("previousPageId")]
        public string PreviousPageId { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("sections")]
        public List<Section> Sections { get; set; }
    }

    public class Section {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("settings")]
        public List<Setting> Settings { get; set; }
    }

    public class Setting
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeEnum Type { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("multiple")]
        public bool Multiple { get; set; }

        // Todo: Use typed enum for capabalities
        [JsonProperty("capabilities")]
        public List<string> Capabilities;

        // Todo: Use typed enum for permissions
        [JsonProperty("permissions")]
        public List<string> Permissions;
    }
}