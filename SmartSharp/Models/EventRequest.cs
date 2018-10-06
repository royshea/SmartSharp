namespace SmartSharp.RequestModels
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using static Enums;

    public class EventRequest : ExecutionRequest
    {
        [JsonProperty("eventData")]
        public EventData EventData { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string, string> Settings { get; set; }
    }

    public class EventData
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("installedApp")]
        public InstalledApp InstalledApp { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }

    [JsonConverter(typeof(EventConverter))]
    public class Event
    {
        [JsonProperty("eventType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EventTypeEnum EventType { get; set; }
    }

    public class DeviceEvent : Event
    {
        [JsonProperty("subscriptionName")]
        public string SubscriptionName { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("stateChange")]
        public bool StateChange { get; set; }
    }

    public class ModeEvent : Event
    {
        [JsonProperty("modeId")]
        public string ModeId { get; set; }
    }

    public class TimerEvent : Event
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public TimerTypeEnum TimerType { get; set; }

        // TODO: Validate that this is being deserialized correctly
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }
    }

    public class DeviceCommandsEvent : Event
    {
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("profileId")]
        public string ProfileId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("commands")]
        public List<DeviceCommandsEventCommand> Commands { get; set; }
    }

    public class DeviceCommandsEventCommand
    {
        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("arguments")]
        public List<object> Arguments { get; set; }
    }

    public class EventResponse
    {
        [JsonProperty("eventData")]
        public Object Data { get; set; }
    }
}