using System;

class Program
{
    static void Main(string[] args) {
    
        List<Video> videoList = new List<Video>();

        Video vid1 = new Video("Tom and Jerry Funny Compilation","TomAndJerryChannel",632,1);
        Video vid2 = new Video("Stickman Fight Animations","NerdyChickens",125,2);
        Video vid3 = new Video("Where the Blue Fern Grows | Trailer","Hollywood Central",320,3);

        videoList.Add(vid1);
        videoList.Add(vid2);
        videoList.Add(vid3);

        foreach(Video currentVideo in videoList) {
            currentVideo.videoDetails();
        }

    }
}