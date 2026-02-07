using System.Collections.Generic;
public class Address
{
    private string _street;
    private string _city;
    private string _state;

    public Address (string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }

    private HashSet<string> states = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    { "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA", "HI","ID","IL","IN","IA","KS","KY","LA","ME",
    "MD", "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ", "NM","NY","NC","ND","OH","OK","OR","PA",
    "RI","SC", "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY", "DC"};

    public bool IsFromUSA()
    {
        return states.Contains(_state);
    }

    public string GetDisplayText()
    {
        return $"{_street}, {_city}, {_state}";
    }
}