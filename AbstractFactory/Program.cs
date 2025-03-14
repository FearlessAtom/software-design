using System.Text;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        IDeviceFactory Factory;

        while(true)
        {
            StringBuilder Prompt = new StringBuilder().
                AppendLine("1) IProne Factory").
                AppendLine("2) Kiaomi Factory").
                AppendLine("3) Balaxy Factory").
                Append("> ");

            Console.Write(Prompt.ToString());

            string Input = Console.ReadLine() ?? "";

            int Output;

            if (!int.TryParse(Input, out Output))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (Output)
            {
                case 1:
                {
                    Factory = new IProneFactory();
                    break;
                }

                case 2:
                {
                    Factory = new KiaomiFactory();
                    break;
                }

                case 3:
                {
                    Factory = new BalaxyFactory();
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid option!");
                    continue;
                }
            }

            break;
        }

        Console.WriteLine();

        Laptop Laptop = Factory.CreateLaptop();

        Console.WriteLine();
        Laptop.DisplayInfo();
        Console.WriteLine();
        Laptop.DoWork();

        Console.WriteLine();

        Netbook Netbook = Factory.CreateNetbook();

        Console.WriteLine();
        Netbook.DisplayInfo();
        Console.WriteLine();
        Netbook.BrowseInternet();

        Console.WriteLine();

        EBook EBook = Factory.CreateEBook();

        Console.WriteLine();
        EBook.DisplayInfo();
        Console.WriteLine();
        EBook.ReadBook();

        Console.WriteLine();

        Smartphone Smartphone = Factory.CreateSmartphone();

        Console.WriteLine();
        Smartphone.DisplayInfo();
        Console.WriteLine();
        Smartphone.ScrollSocialMedia();
    }
}
