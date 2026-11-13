using System;
namespace Lab09.Assignment09
{
    internal class UserBrowser
    {
        //Relationship Type: Dependency

        //A user temporarily uses a browser.

        //The browser is not owned by the user.
    }

    internal class Browser
    {
        public void OpenWebsite(string url)
        {
            Console.WriteLine($"Opening {url}");
        }
    }

    internal class User
    {
        public void Browse(Browser browser)
        {
            browser.OpenWebsite("www.google.com");
        }
    }
}
