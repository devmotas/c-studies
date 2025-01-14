



using UserPost.Entities;

Comment comment1 = new Comment("Have a nice trip!");
Comment comment2 = new Comment("Woww that's awesome!");

Post post1 = new Post
{
    Title = "Traveling to New Zealand",
    Content = "I'm going to visit this wonderful country!",
    Likes = 12,
    Moment =  DateTime.Parse("21/06/2025 13:05:44"),
};

post1.AddComment(comment1);
post1.AddComment(comment2);

Comment comment3 = new Comment("Good night");
Comment comment4 = new Comment("May the force be with you");

Post post2 = new Post
{
    Title = "Good night guys",
    Content = "See you tomorrow",
    Likes = 5,
    Moment = DateTime.Parse("28/07/2025 23:14:19"),
};

post2.AddComment(comment3);
post2.AddComment(comment4);

Console.WriteLine(post1.ToString());
Console.WriteLine(post2.ToString());