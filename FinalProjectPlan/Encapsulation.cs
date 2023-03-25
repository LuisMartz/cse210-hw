using System;

public class Product
{
    private int productId;
    private string productName;
    private double price;
    private int quantity;

    public Product(int productId, string productName, double price, int quantity)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double GetTotalPrice()
    {
        return price * quantity;
    }
}

public class Customer
{
    private string customerName;
    private Address customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        this.customerName = customerName;
        this.customerAddress = customerAddress;
    }

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public Address CustomerAddress
    {
        get { return customerAddress; }
        set { customerAddress = value; }
    }

    public bool IsInUSA()
    {
        return customerAddress.IsInUSA();
    }
}

public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string StreetAddress
    {
        get { return streetAddress; }
        set { streetAddress = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return streetAddress + "\n" + city + ", " + state + " " + country;
    }
}

public class Order
{
    private int orderId;
    private Customer customer;
    private List<Product> products;

    public Order(int orderId, Customer customer, List<Product> products)
    {
        this.orderId = orderId;
        this.customer = customer;
        this.products = products;
    }

    public int OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
}}
