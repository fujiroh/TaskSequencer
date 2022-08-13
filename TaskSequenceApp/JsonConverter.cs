using System.Collections.Generic;
using Newtonsoft.Json;

namespace TaskSequenceApp
{
    public static class JsonConverter<T> where T : ISerializable

    {
    // Serialize : 内部データ -> Json
    public static string ConvertToJson(IEnumerable<ISerializable> innerData)
    {
        var jsonData = JsonConvert.SerializeObject(innerData);
        return jsonData;
    }

    // Deserialize : Json -> 内部データ
    public static IEnumerable<T> ConvertToInnerValue(string jsonData)
    {
        var innerData = JsonConvert.DeserializeObject<IList<T>>(jsonData);
        return innerData;
    }
    }
}