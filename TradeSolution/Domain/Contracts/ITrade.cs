namespace TradeSolution.Domain.Contracts
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
