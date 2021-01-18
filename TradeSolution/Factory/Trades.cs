using System;
using System.Collections.Generic;
using System.Text;
using TradeSolution.Domain.Contracts;

namespace TradeSolution.Factory
{
    public class Trade1 : ITrade
    {
        public double Value { get; }

        public string ClientSector { get; }

        public Trade1()
        {
            Value = 2000000;
            ClientSector = "Private";
        }
    }

    public class Trade2 : ITrade
    {
        public double Value { get; }

        public string ClientSector { get; }

        public Trade2()
        {
            Value = 400000;
            ClientSector = "Public";
        }
    }

    public class Trade3 : ITrade
    {
        public double Value { get; }

        public string ClientSector { get; }

        public Trade3()
        {
            Value = 500000;
            ClientSector = "Public";
        }
    }

    public class Trade4 : ITrade
    {
        public double Value { get; }

        public string ClientSector { get; }

        public Trade4()
        {
            Value = 3000000;
            ClientSector = "Public";
        }
    }
}
