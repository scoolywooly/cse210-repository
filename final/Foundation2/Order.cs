using System.Dynamic;

public class Order {
    protected List<Product> _reciept = new List<Product>();
    protected Customer customer = new Customer();

    

    public Order(string name, string address) {
        customer.setDetails(name, address);

    }


    public void addProduct(Product product) {
        _reciept.Add(product);
    }

    public double totalCost() {
        double totalCost = 0.00;

        foreach (Product product in _reciept) {
            totalCost += product.getTotal();
        }

        return totalCost;
    }

    public string getShippingLabel() {
        string name = customer.getName();
        
        string address = customer.Address();

        return $"{name}:\n{address}\n\n";
    }

    public string getPackingLabel() {
        string packingLabel = "";
        foreach (Product product in _reciept) {
            string[] productInventory = product.getProductDetails();
            string name = productInventory[1];
            double price = Convert.ToDouble(productInventory[2]);
            int quantity = Int32.Parse(productInventory[3]);

            packingLabel += $"----------------\n{name}\nPrice: ${price}\nQuantity:{quantity}\n";
            
        }
        return packingLabel;
    }

    public double shippingTax() {
        bool boughtFromUSA = customer.livesInUSA();
        int tax;
        if (boughtFromUSA == true) {
            tax = 5;
        } else {
            tax = 35;
        }
        return Convert.ToDouble(tax);
    }

}