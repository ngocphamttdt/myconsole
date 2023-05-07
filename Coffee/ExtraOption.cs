namespace myconsole.Coffee
{
    public class ExtraOption
    {
        public Topping Topping { get; set; }
        public Size Size { get; set; }
    }
    
    public class Topping{
        public string Name { get; set; }
       

        public decimal getPrice(){
            if(Name == "milk") return 1M;
            else if(Name =="Jelly") return 1.5M;
            return 0M;
        }

    }

    public class Size{
        public string Name { get; set; }

        public decimal getPrice(){
            if(Name == "small") return 0.2M;
            else if(Name =="medium") return 0.4M;
            else if(Name =="large") return 0.6M;
            return 0M;
        }
    }

    // enum Topping{
    //     Milk = 1M,
    //     Jelly= 1.5M
    // }
    // enum Size{
    //     Small= 0.2M,
    //     Medium= 0.4M,
    //     Large = 0.6M
    // }
}