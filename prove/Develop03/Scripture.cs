using System.Threading.Channels;

public class Scripture {


// member variables.
    List<Word> _scriptureText = new List<Word>();
    Reference _scriptureTitle;

// constructor
    public Scripture(Reference scripture, string text) {

        _scriptureTitle = scripture;
        
        // We parse through the text to add each word to thie list of words

        string[] wordList = text.Split(' ', '\n');
        foreach (string wordText in wordList) {
            Word currentWord = new Word(wordText);

            _scriptureText.Add(currentWord);
        }
    }

// Methods
    public void HideRandomWords(int numberToHide) {
        int howManyHidden = 0;

        Random rnd = new Random();
        

        foreach (Word word in _scriptureText) {
            int chanceToHide = rnd.Next(1,8); 
            bool isHiddenAlready = word.IsHidden();


            if (chanceToHide > 5 && howManyHidden <= numberToHide && isHiddenAlready == false) {
                word.Hide();
                howManyHidden++;
            }
            
        } 
        //Console.Clear();
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _scriptureText) {

           bool blankWord = word.IsHidden();

           if (blankWord == false) {
               return false; 
           }
        }

        // if the loop runs without a hitch then that means none of the words were shown
        return true;
    }

    public string GetDisplayText() {

        string fullScriptureText = _scriptureTitle.GetDisplayText(); // This is the string that we compile the words to.

        foreach (Word individualWord in _scriptureText) { // I love foreach loops
            string addWord = individualWord.GetDisplayText();
            fullScriptureText += addWord + ' '; // adds each word with a space between.
        } 

        return fullScriptureText;
    }

        
    
    
}



    


