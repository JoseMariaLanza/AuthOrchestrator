using AuthOrchestrator.Redis;
using StackExchange.Redis;
using System.Text.Json;

namespace AuthOrchestrator.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IDatabase _database;

        public AuthService(IRedisHelper redisHelper)
        {
            _database = redisHelper.GetDatabase();
        }

        public async Task<object?> GetUser(string userToken)
        {
            var userData = _database.StringGet(userToken);
            if (userData.IsNullOrEmpty) return null;

            var userModel = JsonSerializer.Deserialize<object>(userData);

            return userModel;
        }
    }
}