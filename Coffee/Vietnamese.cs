using System;

namespace myconsole.Coffee
{
  public class Vietnamese: CoffeeBean{
    public string Location { get; set; }
    public override decimal getDouble (){
            return Cost * 2;
      }

    public Vietnamese(string name, decimal cost,  string location){
      Name = name;
      Cost = cost;
      Location = location;
    }
   
  }
}