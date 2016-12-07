using System.Collections.Generic;
using System.Linq;
using Contracts;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Domain
{
    public class RedisCacheHelper
    {
        private ConnectionMultiplexer _redisConnection;
        private IDatabase _redisCache;

        public RedisCacheHelper()
        {
            _redisConnection = ConnectionMultiplexer.Connect("tekierredis.redis.cache.windows.net:6380,password=U6QGvKYiPc/+ryeTFN+zoXhOd6QomzfUKLtRolhQSa8=,ssl=True,abortConnect=False");
            _redisCache = _redisConnection.GetDatabase();
        }

        public void AddToCache(List<Character> newItem)
        {
            _redisCache.StringSet(newItem.Count > 1 ? "full list" : newItem.First().RowKey,
                JsonConvert.SerializeObject(newItem));
        }

        public List<Character> RetrieveFromCache(string retrievalKey)
        {
            return JsonConvert.DeserializeObject<List<Character>>(_redisCache.StringGet(retrievalKey));
        }

        public bool CheckIfInCache(string key)
        {
            return _redisCache.KeyExists(key);
        }

        public void ClearTheWholeThing()
        {
            _redisCache.KeyDelete("*");
        }
    }
}
