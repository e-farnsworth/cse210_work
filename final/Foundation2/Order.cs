public class Order
{
    private Adress _adress;
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private string _packingLabel;
    private string _shippingLabel;
    private double _costTotal;
    //List of products and a customer
    //return a string for the packing label
    //return a string for the shipping label
    //calculate total cost

    public Order(string customerName, string streetAdress, string city, string state, string country)
    {
        _adress = new Adress(streetAdress, city, state, country);
        _customer = new Customer(customerName, _adress);
        _costTotal = 0;
    }

    public void AddToCart(Product product)
    {
        _products.Add(product);
    }

    public string TotalPrice()
    {
        foreach (Product product in _products)
        {
            _costTotal += product.GetFullPrice();
        }

        if (_customer.AdressInUSA() == true)
        {
            _costTotal += 5;
        }
        else
        {
            _costTotal += 35;
        }

        return $"${Math.Round(_costTotal,2)}";
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInformation());
        }
    }

    public void DisplayShippingLabel()
    {
        Adress _adress = _customer.GetAdress();
        Console.Write(_adress.PrintAdress());
    }
}