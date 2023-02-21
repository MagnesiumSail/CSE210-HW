public class Address
{
    string street = "";
    string city = "";
    string state = "";
    int postalCode = 0;
    bool validated = false;
    public Address(string _street, string _city, string _state, int _postalCode)
    {
        street = _street;
        city = _city;
        state = _state;
        postalCode = _postalCode;
    }
    public bool Validate()
    {
        Console.WriteLine($"Is you address: {street} {city}, {state}: {postalCode}?");
        Console.WriteLine("y/n");

        string input = Console.ReadLine();

        if (input == "y")
        {
            validated = true;
            Console.WriteLine("Validated!");
        }
        else
        {
            validated = false;
        }
        return validated;
    }
    public void outputAsLabel()
    {
        Console.WriteLine($"{street} {city}, {state}: {postalCode}");
    }


}