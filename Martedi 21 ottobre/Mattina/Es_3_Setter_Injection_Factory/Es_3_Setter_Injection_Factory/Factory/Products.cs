namespace Es_3_Setter_Injection_Factory.Factory;

public class Products
{
    public class DigitalBook : IProduct
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class PrintedBook : IProduct
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
