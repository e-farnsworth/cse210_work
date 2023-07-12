public class Product
{
    private string _nameProduct;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price)
    {
        _nameProduct = name;
        _productID = productID;
        _price = price;
        _quantity = 1;
    }

    public Product(string name, string productID, double price, int quantity)
    {
        _nameProduct = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetFullPrice()
    {
        double fullPrice = _price * (double)_quantity;
        return fullPrice;
    }

    public string GetProductInformation()
    {
        return $"{_nameProduct}:{_productID}";
    }
}