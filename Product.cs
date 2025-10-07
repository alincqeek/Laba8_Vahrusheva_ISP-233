class Product
{
    public string Name { get; set; }
    public decimal Price
    {
        get; set;
    }
    public int _quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            if (value < 0) { _quantity = 0; }
            else _quantity = value;
        }

    }
    public decimal TotalPrice
    {
        get
        {
            return Price = _quantity;
        }
    }
}