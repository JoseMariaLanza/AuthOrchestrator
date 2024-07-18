namespace AuthOrchestrator.Auth
{
    public interface IAuthService
    {
        Task<object?> GetUser(string key);
    }
}
