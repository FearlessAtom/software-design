namespace AbstractFactory;

interface IDeviceFactory
{
    Laptop CreateLaptop();

    Netbook CreateNetbook();

    EBook CreateEBook();

    Smartphone CreateSmartphone();
}
