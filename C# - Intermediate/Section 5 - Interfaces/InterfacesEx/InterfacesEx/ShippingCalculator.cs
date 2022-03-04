namespace InterfacesEx
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalCost < 30f)
                return order.TotalCost * 0.1f;

            return 0;
        }
    }
}
