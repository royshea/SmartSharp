namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;

    public class OAuthCallbackRequest : ExecutionRequest
    {
        [JsonProperty("oAuthCallbackData")]
        public OAuthCallbackData OAuthCallbackData { get; set; }
    }

    public class OAuthCallbackData
    {
        [JsonProperty("installedAppId")]
        public string InstalledAppId { get; set; }

        [JsonProperty("urlPath")]
        public string UrlPath { get; set; }
    }

    public class OauthCallbackResponse
    {
        [JsonProperty("oAuthCallbackData")]
        public object OAuthCallbackData { get; set; }
    }
}
