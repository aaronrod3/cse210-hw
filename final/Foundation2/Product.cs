using System;


// contains info of each product
public class Product
{
    private string _productname;
    private string _productid;
    private string _price;
    public string _quantity;


    public Product(string name, string id, string price, string quantity)
    {
        _productname = name;
        _productid = id;
        _price = price;
        _quantity = quantity;
    }

    public string productstring()
    {
        string product = $"{_productname}, {_productid}, {_price}, {_quantity}";
        return product;
    }
}