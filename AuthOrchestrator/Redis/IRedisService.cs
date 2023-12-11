using StackExchange.Redis;

namespace AuthOrchestrator.Redis
{
    public interface IRedisHelper
    {
        IDatabase GetDatabase();
    }

    public interface IRedisService
    {
        Task<bool> SetStringAsync(string key, string value);
        Task<string?> GetStringAsync(string key);
        Task<bool> RemoveKeyAsync(string key);
    }
}
