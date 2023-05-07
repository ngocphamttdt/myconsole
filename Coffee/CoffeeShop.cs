namespace myconsole.Coffee
{
    public class CoffeeShop
    {
        public decimal calculateCost (CoffeeOrder order){
            decimal cost = 0M;
            foreach (var item in order.CoffeeOrderItems)
            {
                cost += item.VietnameseCoffee.Cost + item.Options.Topping.getPrice()+ item.Options.Size.getPrice();
            }
            return cost;
        }
    }
}
