public class Adress
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Adress(string StreetAdress, string city, string stateProvice, string country)
    {
        _streetAdress = StreetAdress;
        _city = city;
        _state = stateProvice;
        _country = country;
    }

    public bool AdressInUSA() // Whether the adress is in the USA or not
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string PrintAdress()
    {
        return $"{_streetAdress}\n" + $"{_city}, {_state}\n" + $"{_country}\n";
    }
}