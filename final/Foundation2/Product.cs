using System.Data.Common;
using System.Reflection;

public class Product {
    protected string _productName;
    protected int _productID;
    protected double _productPrice;
    protected int _productQuantity;

    public Product(string name, int id, double price, int quantity) {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public double getTotal() {
        double ammount = Convert.ToDouble(_productQuantity);
        double totalPrice = ammount * _productPrice;
        return totalPrice;
    }
    public string getProductName() {
        return _productName;
    }

    public string[] getProductDetails() {
        string[] details = {_productID.ToString(), _productName, _productPrice.ToString(), _productQuantity.ToString()};
        return details;
    }

}