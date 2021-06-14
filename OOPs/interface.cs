using System;

namespace Program
{
    class Interfaces
    {
        interface Sweden
        {
            // interface method does not have a body
            void WhereDoYouLive();

            // Interface can not have a field
            // int i;

            // Compiler error if we use public/protected/private
            // it is public by default
            // public void printName(string text);
         }

        // Multiple interfaces
        interface Denmark
        {
            void WhereYourFriendLive();
        }

        class Lives : Sweden, Denmark
        {
            public void WhereDoYouLive()
            {
                Console.WriteLine("I live in Halmstad, Sweden");
            }

            public void WhereYourFriendLive()
            {
                Console.WriteLine("My friend lives in Denmark");
            }
        }
        
        static void Main(string[] args)
        {
            Lives state = new Lives();
            state.WhereDoYouLive();
            state.WhereYourFriendLive();
        }
    }
}
