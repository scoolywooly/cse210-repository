public class Address 
{
    private string _address;


    public bool isInUSA() {
        string countryToLookFor = "USA";
        if (_address.Contains(countryToLookFor) == true) {
            return true;
        } else {
            return false;
        }

    }

    public void setAddress(string text) {
        _address = text;
    }

    public string getAddress() {
        return _address;
    }
}