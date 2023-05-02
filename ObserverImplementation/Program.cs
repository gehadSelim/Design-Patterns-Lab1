namespace ObserverImplementation
{
    class Stock
    {
        private string _symbol;
        private double _price;

        public event EventHandler<StockEventArgs> PriceChanged;
        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPriceChanged(new StockEventArgs(_symbol, _price));
                }
            }
        }

        // Raises the PriceChanged event
        protected virtual void OnPriceChanged(StockEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }

    interface IInvestor
    {
        void Update(object sender, StockEventArgs e);
    }

    class Investor : IInvestor
    {
        private string _name;

        // Constructor
        public Investor(string name)
        {
            _name = name;
        }

        public void Update(object sender, StockEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", _name, e.Symbol, e.Price);
        }
    }

    class StockEventArgs : EventArgs
    {
        private string _symbol;
        private double _price;

        public StockEventArgs(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public string Symbol { get { return _symbol; } }
        public double Price { get { return _price; } }
    }

    class Program
    {
        static void Main()
        {
            Stock ibm = new Stock("IBM", 120.00);
            Investor investor1 = new Investor("Sorros");
            Investor investor2 = new Investor("Berkshire");
            ibm.PriceChanged += investor1.Update;
            ibm.PriceChanged += investor2.Update;

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

        }
    }
}