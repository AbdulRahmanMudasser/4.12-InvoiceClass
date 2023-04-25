class Invoice
{
    // declaring variables
    private string partNumber;
    private string partDescription;
    private int quantity;
    private decimal price;

    // constructor
    public Invoice(string partNumber, string partDescription, int quantity, decimal price)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = quantity;
        Price = price;
    }


    // properties
    public string PartNumber
    {
        get { return partNumber; }
        set { partNumber = value; }
    }

    public string PartDescription
    {
        get { return partDescription; }
        set { partDescription = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (quantity >= 0)
            {
                quantity = value;
            }
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price >= 0)
            {
                price = value;
            }
        }
    }
    
    // GetInvoiceAmount method
    public decimal GetInvoiceAmount()
    {
        return Quantity * Price;
    }
}
// end of Invoice class