namespace TradeSolution.Domain.Entities
{
    public class CategoryRule : AggregateRoot
    {
        public string Name { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public string ClientSector { get; set; }
    }
}
