public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    

    public Event(string title, string description, string date, string time, Address address, string type )
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }
    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{_address.ToString()}\n";
    }
    public virtual string FullDetails()
    {
        return "";
    }
    public string ShortDetails()
    {
        return $"Type: {_type}\nTitle: {_title}\nDate: {_date}\n";
    }
}