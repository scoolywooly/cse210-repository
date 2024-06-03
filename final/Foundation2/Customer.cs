public class Customer {
    protected string _customerName;
    
    protected Address _customerAddress = new Address();

    public void setDetails(string name, string address) {
        _customerName = name;
        _customerAddress.setAddress(address);
    }

    public bool livesInUSA() {
        bool usa = _customerAddress.isInUSA();
        return usa;
    }

    public string Address() {
        return _customerAddress.getAddress();
    }

    public string getName() {
        return _customerName;
    }
}
