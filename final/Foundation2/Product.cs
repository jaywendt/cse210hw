using System;

public class Product
{
    private string _prodName;
    private int _prodID;
    private float _price;
    private int _quantity;

    public Product(string prodName, int prodID, float price, int quantity)
    {
        _prodName = prodName;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotalPrice(quantity quantity, price price)
    {
        int totalPrice = price * quantity;
    }
}