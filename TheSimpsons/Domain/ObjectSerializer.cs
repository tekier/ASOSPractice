using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Domain
{
    public class ObjectSerializer
    {
        private BinaryFormatter _formatter;

        public ObjectSerializer()
        {
            _formatter = new BinaryFormatter();
        }
        public byte[] SerializeObject(object character)
        {
            if (character == null)
                return null;
            using (MemoryStream stream = new MemoryStream())
            {
                _formatter.Serialize(stream, character);
                var characterAsStream = stream.ToArray();
                return characterAsStream;
            }
        }

        public List<T> DeserializeObject<T>(byte[] stringGet)
        {
            if (stringGet == null)
            {
                return null;
            }
            using (MemoryStream stream = new MemoryStream())
            {
                List<T> result = _formatter.Deserialize(stream) as List<T>;
                return result;
            }
        }
    }
}
