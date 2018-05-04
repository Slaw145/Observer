using System;
using System.Threading.Tasks;

namespace FacebookMulithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookPost facebookPost=FacebookPost.GetInstance();

            Task task1 = Task.Run(() =>
            {
                FacebookUser facebookUser1 = new FacebookUser("Slawek");
                facebookPost.commentPost(facebookUser1);
            });

            task1.Wait();

            Task task2 = Task.Run(() =>
            {
                FacebookUser facebookUser2 = new FacebookUser("Charlie");
                facebookPost.commentPost(facebookUser2);
                facebookPost.addNewNotify();
            });

            task2.Wait();

            Task task3 = Task.Run(() =>
            {
                FacebookUser facebookUser3 = new FacebookUser("Nidhi");
                facebookPost.commentPost(facebookUser3);
                facebookPost.addNewNotify();
            });

            task3.Wait();

            Console.ReadKey();
        }
    }
}
