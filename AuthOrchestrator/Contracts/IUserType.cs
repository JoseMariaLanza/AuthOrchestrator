namespace AuthOrchestrator.Contracts
{
    public interface IUserType
    {
        int Id { get; }
        public string Name { get; }
        public string Type { get; }
    }
}
