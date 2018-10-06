namespace SmartSharp
{
    public class Enums
    {
        public enum LifeCycleEnum
        {
            INSTALL,
            UPDATE,
            UNINSTALL,
            EVENT,
            PING,
            CONFIGURATION,
            OAUTH_CALLBACK
        }

        public enum PhaseEnum
        {
            INITIALIZE,
            PAGE
        }

        public enum ValueTypeEnum
        {
            STRING,
            DEVICE,
            MODE
        }

        public enum TypeEnum
        {
            DEVICE,
            TEXT,
            PASSWORD,
            BOOLEAN,
            ENUM,
            MODE,
            SCENE,
            LINK,
            PAGE,
            IMAGE,
            IMAGES,
            VIDEO,
            TIME,
            PARAGRAPH,
            EMAIL,
            DECIMAL,
            NUMBER,
            PHONE,
            OAUTH
        }

        public enum EventTypeEnum
        {
            DEVICE_EVENT,
            TIMER_EVENT,
            DEVICE_COMMANDS_EVENT,
            MODE_EVENT
        }

        public enum TimerTypeEnum
        {
            CRON,
            ONCE
        }

        public enum SubscriptionSourceEnum
        {
            DEVICE,
            CAPABILITY
        }
    }
}
