using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PinPayments
{
    public static class JsonConverter
    {
        public static T Deserialize<T>(string json, string dateFormat = "yyyy-MM-ddTHH:mm:ssZ")
        {
            try
            {
                var settings = new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat(dateFormat),
                    
                };
                var _Bytes = Encoding.Unicode.GetBytes(json);
                using (MemoryStream _Stream = new MemoryStream(_Bytes))
                {

                    var _Serializer = new DataContractJsonSerializer(typeof(T), settings);

                    return (T)_Serializer.ReadObject(_Stream);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
