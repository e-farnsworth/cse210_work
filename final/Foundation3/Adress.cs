public class Adress
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Adress(string StreetAdress, string city, string stateProvice)
    {
        _streetAdress = StreetAdress;
        _city = city;
        _state = stateProvice;
        // _country = country;
    }

    public string PrintAdress()
    {
        return $"{_streetAdress}\n" + $"{_city}, {_state}\n";
    }
}