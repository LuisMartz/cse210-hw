
class Address
{
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public string GetFormattedAddress()
    {
        return $"{street}, {city}, {state} {zip}";
    }
}

class Event
{
    private string name;
    private DateTime date;
    private DateTime time;
    private Address address;
    private string eventType;

    public Event(string name, DateTime date, DateTime time, Address address, string eventType)
    {
        this.name = name;
        this.date = date;
        this.time = time;
        this.address = address;
        this.eventType = eventType;
    }

    public string GetName()
    {
        return name;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public DateTime GetTime()
    {
        return time;
    }

    public string GetFormattedDate()
    {
        return date.ToString("D");
    }

    public string GetFormattedTime()
    {
        return time.ToString("h:mm tt");
    }

    public Address GetAddress()
    {
        return address;
    }

    public string GetEventType()
    {
        return eventType;
    }

    public virtual string GetMarketingMessage(string detailsOption)
    {
        if (detailsOption == "Standard details")
        {
            return $"{GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()}";
        }
        else if (detailsOption == "Full details")
        {
            if (GetEventType() == "Lecture")
            {
                return $"{GetEventType()} - {GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()} - Speaker: {((Lecture)this).GetSpeaker()}, Capacity: {((Lecture)this).GetCapacity()}";
            }
            else if (GetEventType() == "Reception")
            {
                return $"{GetEventType()} - {GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()} - RSVP email: {((Reception)this).GetRsvpEmail()}";
            }
            else if (GetEventType() == "Outdoor Gathering")
            {
                return $"{GetEventType()} - {GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()} - Weather: {((OutdoorGathering)this).GetWeatherStatement()}";
            }
            else
            {
                return "";
            }
        }
        else if (detailsOption == "Short description")
        {
            return $"{GetEventType()} - {GetName()} - {GetFormattedDate()}";
        }
        else
        {
            return "";
        }
    }
     public string GetSummary()
    {
        return $" Name: {name} | Date: {date.ToShortDateString()}";
    }

}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string name, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(name, date, time, address, "Lecture")
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string GetSpeaker()
    {
        return speaker;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public override string GetMarketingMessage(string detailsOption)
    {
        if (detailsOption == "Standard details")
        {
            return $"{GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()}";
        }
        else if (detailsOption == "Full details")
        {
            return $"{base.GetMarketingMessage("Standard details")} - Speaker: {GetSpeaker()}, Capacity: {GetCapacity()}";
        }
        else if (detailsOption == "Short description")
        {
        return $"{GetType()} - {GetName()} - {GetFormattedDate()} - Speaker: {GetSpeaker()}";
        }
        else
        {
        return "";
        }
    }
    
}

class Reception : Event
{
private string rsvpEmail;
public Reception(string name, DateTime date, DateTime startTime, Address address, string rsvpEmail) : base(name, date, startTime, address, "Reception")
{
    this.rsvpEmail = rsvpEmail;
}

public string GetRsvpEmail()
{
    return rsvpEmail;
}

public override string GetMarketingMessage(string detailsOption)
{
    if (detailsOption == "Standard details")
    {
        return $"{GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()}";
    }
    else if (detailsOption == "Full details")
    {
        return $"{base.GetMarketingMessage("Standard details")} - RSVP email: {GetRsvpEmail()}";
    }
    else if (detailsOption == "Short description")
    {
        return $"{GetType()} - {GetName()} - {GetFormattedDate()} - RSVP email: {GetRsvpEmail()}";
    }
    else
    {
        return "";
    }
    }
}

class OutdoorGathering : Event
{
private string weatherStatement;
public OutdoorGathering(string name, DateTime date, DateTime time, Address address, string weatherStatement) : base(name, date, time, address, "Outdoor Gathering")
{
    this.weatherStatement = weatherStatement;
}

public string GetWeatherStatement()
{
    return weatherStatement;
}

public override string GetMarketingMessage(string detailsOption)
{
    if (detailsOption == "Standard details")
    {
        return $"{GetName()} - {GetFormattedDate()} at {GetFormattedTime()} - {GetAddress().GetFormattedAddress()}";
    }
    else if (detailsOption == "Full details")
    {
        return $"{base.GetMarketingMessage("Standard details")} - Weather: {GetWeatherStatement()}";
    }
    else if (detailsOption == "Short description")
    {
        return $"{GetType()} - {GetName()} - {GetFormattedDate()} - Weather: {GetWeatherStatement()}";
    }
    else
    {
        return "";
    }
}
}