using TradeSolution.Domain.Contracts;

namespace TradeSolution.Domain.Entities
{
    public class Trade : AggregateRoot, ITrade
    {
        public double Value { get; }

        public string ClientSector { get; }

        public Trade(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }
    }
}
