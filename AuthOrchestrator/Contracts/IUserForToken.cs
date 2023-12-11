namespace AuthOrchestrator.Contracts
{
    public interface IUserForToken
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string UserName { get; }
        ICollection<IUserEmail> Emails { get; }
        IUserType UserType { get; }
    }
}
