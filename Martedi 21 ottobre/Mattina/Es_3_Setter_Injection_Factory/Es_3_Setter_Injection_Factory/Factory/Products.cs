namespace Es_3_Setter_Injection_Factory.Factory;

public class Products
{
    public class PrintedBook : IProduct
    {
        public string Title { get; set; } = "Libro Stampato";
        public double Price { get; set; } = 25;
    }

    public class DigitalBook : IProduct
    {
        public string Title { get; set; } = "Libro Digitale";
        public double Price { get; set; } = 10;
    }
}
