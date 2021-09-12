using System;

namespace Boss_Project
{
    public class User
    {
        public void SignIn()
        {
            Console.WriteLine("Username : ");
            string username = Console.ReadLine();

            Console.WriteLine("Password : ");
            string password = Console.ReadLine();
        }
    }
}
