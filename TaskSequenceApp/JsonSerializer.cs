using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace TaskSequenceApp
{
    public static class JsonSerializer
    {
        /// <summary>
        /// 書き出し
        /// </summary>
        /// <param name="data">Taskのデータ</param>
        /// <param name="outputPath">出力用パス</param>
        public static void Write(IEnumerable<TaskDataProperty> data, string outputPath)
        {
            using (var stream = new MemoryStream())
            using (var fs = new FileStream(outputPath, FileMode.Open))
            using (var sw = new StreamWriter(fs))
            {
                var serializer = new DataContractJsonSerializer(typeof(IList<TaskDataProperty>));
                var convertToJson = JsonConverter<TaskDataProperty>.ConvertToJson(data);
                serializer.WriteObject(stream, convertToJson);
                sw.Write(Encoding.UTF8.GetString(stream.ToArray()));
            }
        }
        
        /// <summary>
        /// 読み込み
        /// </summary>
        /// <param name="inputPath">入力用パス</param>
        /// <returns>Json形式のデータ</returns>
        public static string Read(string inputPath)
        {
            string jsonData;
            using (var sr = new StreamReader(inputPath, Encoding.UTF8))
            {
                jsonData = sr.ReadToEnd();
            }
            return jsonData;
        }
    }
}