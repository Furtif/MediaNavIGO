using Newtonsoft.Json;

namespace MediaNavIGO.Utils
{
    public static class JsonUtils
    {
        public static string ToJson<T>(T data, bool formatting = false)
        {
            Formatting format = Formatting.None;

            if (formatting)
                format = Formatting.Indented;

            return JsonConvert.SerializeObject(data, format, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                PreserveReferencesHandling = PreserveReferencesHandling.All
            });
        }

        public static T FromJson<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Error = HandleEventHandler
            });
        }

        public static void HandleEventHandler(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs)
        {
            _ = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
    }
}
