public class Customer
{
    private string _name;
    private Adress _adress;

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public bool AdressInUSA()
    {
        return _adress.AdressInUSA();
    }

    public Adress GetAdress()
    {
        return _adress;
    }
}