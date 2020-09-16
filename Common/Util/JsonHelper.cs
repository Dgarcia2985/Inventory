using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Util
{
    public static class JsonHelper
    {
        public static object ConvertJsonToObject(string json)
        {
            var objString = JsonConvert.DeserializeObject(json);
            return objString;
        }

        public static string ConvertGenericListToJson<T>(List<T> dataList)
        {
            return JsonConvert.SerializeObject(dataList);
        }

        public static T ConvertJsonToGenericObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ConvertGenericToJson<T>(T dataList)
        {
            return JsonConvert.SerializeObject(dataList);
        }
    }
}
