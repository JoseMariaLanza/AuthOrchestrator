using StackExchange.Redis;

namespace AuthOrchestrator.Redis
{
    public class RedisHelper : IRedisHelper
    {
        private readonly ConnectionMultiplexer _redisConnection;

        public RedisHelper(string connectionString)
        {
            _redisConnection = ConnectionMultiplexer.Connect(connectionString);
        }

        public IDatabase GetDatabase() => _redisConnection.GetDatabase();
    }
}
