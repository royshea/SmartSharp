namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using static Enums;

    [JsonConverter(typeof(ExecutionRequestConverter))]
    public class ExecutionRequest
    {
        [JsonProperty("lifeCycle")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LifeCycleEnum LifeCycle { get; set; }

        [JsonProperty("executionId")]
        public string ExecutionId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
