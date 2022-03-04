namespace InterfacesEx
{
    public class Order
    {
        private bool _isShipped;
        private float _totalCost;
        //private string _shipment;
        public Shipment Shipment { get; set; }

        public bool IsShipped
        {
            get { return _isShipped; }
            set { _isShipped = value; }
        }

        public float TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        //public string Shipment 
        //{
        //    get { return _shipment; }
        //    set { _shipment = value; } 
        //}

    }
}
