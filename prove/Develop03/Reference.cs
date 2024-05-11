using System.Security.Cryptography.X509Certificates;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;

        /*
        Moroni 10:4 from the Book of Mormon.

        And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.
        */

    }

    public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    public string GetDisplayText() {
        // determines whether or not we do the end verse
        if (_endVerse != _verse) {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        } else {
            return $"{_book} {_chapter}:{_verse}\n";
        }
        
    }
}