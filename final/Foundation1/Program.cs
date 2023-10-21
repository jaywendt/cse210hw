using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("A History of Spoons", "Silverware Sammy", 6000);
        Comment vid1c1 = new Comment("spoonhugger23", "I love ALL of your videos!");
        Comment vid1c2 = new Comment("TeaSetInspector", "A bit short, but it's an adequate video...");
        Comment vid1c3 = new Comment("RideOfTheReds2023", "Cant appreciate this video without a certain tea party coming to mind.");
        Comment vid1c4 = new Comment("ACertainSamurai", "How did i get to this channel?");
        vid1.AddComment(vid1c1);
        vid1.AddComment(vid1c2);
        vid1.AddComment(vid1c3);
        vid1.AddComment(vid1c4);
        vid1.DisplayVideoInfo();

        Console.WriteLine();

        Video vid2 = new Video("Funny Pranks Go Wrong 2023", "Brookie2019", 300);
        Comment vid2c1 = new Comment("DiagonalKnight", "lol!  great video");
        Comment vid2c2 = new Comment("RainierMomma", "can i upload this video to facebook?");
        Comment vid2c3 = new Comment("trendycatXoXo", "^^ im pretty sure that would be illegal");
        Comment vid2c4 = new Comment("JoLlYpEnGuIn", "the way that horse kicked his head! :0");
        vid2.AddComment(vid2c1);
        vid2.AddComment(vid2c2);
        vid2.AddComment(vid2c3);
        vid2.AddComment(vid2c4);
        vid2.DisplayVideoInfo();

        Console.WriteLine();

        Video vid3 = new Video("10 Terrifying True Stories That Will Literally Haunt You", "TheSpookySpectreSpectator", 6000);
        Comment vid3c1 = new Comment("123youcantseeme", "fake i can see the wires moving around #3");
        Comment vid3c2 = new Comment("halloweenluvvx2000", "Haunt me?  Hah I bet that's just a bunch of--");
        Comment vid3c3 = new Comment("sarcasticcomment", "^ sounds like they got got lol");
        Comment vid3c4 = new Comment("ACertainSamurai", "where am i now");
        vid3.AddComment(vid3c1);
        vid3.AddComment(vid3c2);
        vid3.AddComment(vid3c3);
        vid3.AddComment(vid3c4);
        vid3.DisplayVideoInfo();

        Console.WriteLine();

        Video vid4 = new Video("500 kitten shaped box unboxing video", "mymomsaccount", 60000);
        Comment vid4c1 = new Comment("kittykollector", "SOOOOO CUUUUUUUUUUTE :3");
        Comment vid4c2 = new Comment("JonesFamilyAccount", "wendy this is not an appropriate use of your mothers account.  we will be talking about this later young lady");
        Comment vid4c3 = new Comment("IexistTOinstigate", "ooooooooooooo wendy is in trouble");
        Comment vid4c4 = new Comment("mymomsaccount", "Dad, for the last time, I don't live with you guys anymore, I'm a grown woman");
        vid4.AddComment(vid4c1);
        vid4.AddComment(vid4c2);
        vid4.AddComment(vid4c3);
        vid4.AddComment(vid4c4);
        vid4.DisplayVideoInfo();
    }
}