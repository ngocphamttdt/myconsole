using System;
using myconsole.Coffee;
using System.Collections.Generic;
using System.Linq;

namespace myconsole
{
    class Result{
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            CoffeeOrder order = new CoffeeOrder{
                CoffeeOrderItems = new List<CoffeeOrderItem>{
                   new CoffeeOrderItem{
                    VietnameseCoffee = new Vietnamese("The coffee house", 2.5M, "beach"),
                    Options = new ExtraOption{
                        Topping= new Topping{Name="milk"},
                        Size = new Size{Name="small"}
                    }
                   },
                    new CoffeeOrderItem{
                    VietnameseCoffee = new Vietnamese("Cheese Coffee", 3.5M, "highland"),
                    Options = new ExtraOption{
                        Topping= new Topping{Name="jelly"},
                        Size = new Size{Name="medium"}
                    }
                   }
                }
            };

            var test = order.CoffeeOrderItems.Where(x=>x.VietnameseCoffee.Name =="Cheese Coffee")
            .Select(y=> new Result{Name = y.VietnameseCoffee.Name}).FirstOrDefault();
                                            
             Console.WriteLine($"final: {test.Name}");

            var shop = new CoffeeShop();
            decimal finalCost = shop.calculateCost(order);
            Console.WriteLine($"final: {finalCost}");
        }
    }
}
