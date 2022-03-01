namespace InterfacesEx
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalCost < 30f)
                return order.TotalCost * 0.1f;

            return 0;
        }
    }
}
