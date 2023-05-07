using System;

namespace myconsole.Coffee
{
    public abstract class CoffeeBean
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public abstract decimal getDouble ();
    }
}