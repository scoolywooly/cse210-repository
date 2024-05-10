public class Word {
    private string _text;
    private string _originalText;
    private bool _isHidden;


    // Constructors
    public Word(string text) {
        _text = text;
        _originalText = text;
        _isHidden = false;
    }

    public void Hide() {
        
        string hidden = new string('_',_text.Length);
        _text = hidden;
        _isHidden = true;
        
    }

    public void Show() {

        _text = _originalText;
        _isHidden = false;
    }
    
    public bool IsHidden() {
        if (_isHidden == false) {
            return false;
        } else {
            return true;
        }
    }

    public string GetDisplayText() {
        return _text;
    }



    


}