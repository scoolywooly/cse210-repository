using System.Reflection;

public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private int _commentAmount;
    private int _id;

    protected List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, int videoID) {
        _title = title;
        _author = author;
        _length = length;
        _id = videoID;
        setComments(videoID);
        _commentAmount = _comments.Count();
        
    }

    public string getTitle() {
        return _title;       
    }

    public string getAuthor() {
        return _author;
    }
    public int getLength() {
        return _length;
    }
    public void videoDetails() {
        string videoAuthor = getAuthor();
        string videoName = getTitle();
        int videoLength = getLength();
        
        Console.WriteLine($"----------\nAuthor: {videoAuthor}\nVideo: {videoName}\nLength in seconds: {videoLength}\nComment Count: {_commentAmount}\nComments: \n");
        foreach (Comment currentComment in _comments) {
            
            Console.WriteLine($"Commenter: {currentComment.getName()} \nComment Text: {currentComment.getText()}\n");
       
        }
        

    }

    public void setComments(int videoID) {
        if (videoID == 1) {
                // Make some comments for videoID 1
            Comment com1 = new Comment("Jerry123","I've tried to catch this guy again and again. Now they're making videos about it?");
            _comments.Add(com1);
            Comment com2 = new Comment("TomCat101","Dude, why does the cat always get the short end of the stick. He is just doing his job!");
            _comments.Add(com2);
            Comment com3 = new Comment("ClassicComedyEnjoyer","This is so funny, I can't wait for the mouse to trick the cat again.");
            _comments.Add(com3);
        } else if (videoID == 2) {
                // Make some comments for videoID 2
            Comment com1 = new Comment("TrollCatcher_x1525","Dude. Just stop, you're not that good. BARF");
            _comments.Add(com1);
            Comment com2 = new Comment("ClassicComedyEnjoyer","HEY! @TrollCathcer_x1525 its obvoiuse a channel made by a small company--give them a break, it'll get better.");
            _comments.Add(com2);
            Comment com3 = new Comment("JustSomeGuyWithAMustache","Ikr? btw you spelled obvius wrong.");
            _comments.Add(com3);
        } else if (videoID == 3) {
            // Make some comments for videoID 3
            Comment com1 = new Comment("JustSomeGuyWithAMustache","Can't wait for the movie to come out!\nThe book it's based off of was a critical part of my childhood.");
            _comments.Add(com1);
            Comment com2 = new Comment("Benjamin Buckets","Wow... this is obvousily a cash grab");
            _comments.Add(com2);
            Comment com3 = new Comment("TrollCatcher_x1525","When Jobius said 'It's jobius time!' and jobed all over the place.\nDefinatly the greatest moment in all of cinema.");
            _comments.Add(com3);
        }
    }
}