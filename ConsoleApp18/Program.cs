using ConsoleApp18;

class TechProductAssemblyApp
{
    static void Main()
    {
        Console.WriteLine("Enter the type of tech product (Smartphone, Laptop, Tablet):");
        string productType = Console.ReadLine();

       
        TechProductFactory factory = GetFactory(productType);

       
        Screen screen = factory.CreateScreen();
        Processor processor = factory.CreateProcessor();
        Camera camera = factory.CreateCamera();

        
        screen.Display();
        processor.Process();
        camera.Capture();

        Console.ReadLine(); 
    }

    static TechProductFactory GetFactory(string productType)
    {
        switch (productType.ToLower())
        {
            case "smartphone":
                return new SmartphoneFactory();
            case "laptop":
                return new LaptopFactory();
            case "tablet":
                return new TabletFactory();
            default:
                throw new ArgumentException("Invalid tech product type");
        }
    }
}