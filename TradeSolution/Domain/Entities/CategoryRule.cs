namespace TradeSolution.Domain.Entities
{
    public class CategoryRule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public string ClientSector { get; set; }
    }
}
