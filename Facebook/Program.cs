using System;

namespace ObserverSchema
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookPost facebookPost = new FacebookPost();

            FacebookUser facebookUser1 = new FacebookUser("Slawek");
            facebookPost.commentPost(facebookUser1);

            FacebookUser facebookUser2 = new FacebookUser("Charlie");
            facebookPost.commentPost(facebookUser2);
            facebookPost.addNewNotify();

            FacebookUser facebookUser3 = new FacebookUser("Nidhi");
            facebookPost.commentPost(facebookUser3);
            facebookPost.addNewNotify();

            Console.ReadKey();
        }
    }
}
