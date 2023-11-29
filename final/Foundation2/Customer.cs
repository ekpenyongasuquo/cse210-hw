public class Customer
{
    private string _name;
    private Address _addres;

    public Customer(string name, Address address)
    {
        _name = name;
        _addres = address;

    }
    public string GetName()
    {
        return _name;
    }
    public bool GetIsFromUSA()
    {
        return _addres.GetLivesInUSA();
    }
    public Address GetAddress()
    {
        return _addres;
    }

}