Shop phone = new Shop("Samsung Galaxy S10", 700);
Shop tv = new Shop("Xiaomi smart TV", 400);
Shop mouse = new Shop("Logitech b100", 50);

Client customer = new Client(phone, tv, mouse);

Console.WriteLine($"1.{phone.ProductName}, {phone.ProductCost}$" +
                  $"\n2.{tv.ProductName}, {tv.ProductCost}$" +
                  $"\n3.{mouse.ProductName}, {mouse.ProductCost}$");

customer.Buy();

class Client
{
    private int Wallet = 1000 ;
    Shop phone;
    Shop tv;
    Shop mouse;

    public Client() { }

    public Client(Shop phone, Shop tv, Shop mouse)
    {
        this.phone = phone;
        this.tv = tv;   
        this.mouse = mouse; 
    }
    
    public void Buy()
    {
        Console.WriteLine($"Your ballance {Wallet}$");
        int value = Convert.ToInt32(Console.ReadLine());

        switch(value)
        {
            case 1:
                Wallet -= phone.ProductCost;
                break;

            case 2:
                Wallet -= tv.ProductCost;
                break;

            case 3:
                Wallet -= mouse.ProductCost;
                break;
        }
        Console.WriteLine($"Your ballance {Wallet}$");
    }
}

class Shop
{
    public string ProductName;
    public int ProductCost;

    public Shop (string ProductName, int ProductCost)
    {
    this.ProductName = ProductName;
    this.ProductCost = ProductCost; 
    }
}
