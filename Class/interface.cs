using System;

namespace Program
{
    class Interfaces
    {
        interface Sweden
        {
            // interface method does not have a body
            void WhereDoYouLive();
        }

        // Multiple interfaces
        interface Denmark
        {
            void WhereYourFriendLive();
        }

        class Halmstad : Sweden, Denmark
        {
            public void WhereDoYouLive()
            {
                Console.WriteLine("I am living in Halmstad");
            }
            public void WhereYourFriendLive()
            {
                Console.WriteLine("My friend lives in Denmark");
            }

        }
        
        static void Main(string[] args)
        {
            Halmstad state = new Halmstad();
            state.WhereDoYouLive();
            state.WhereYourFriendLive();
        }
    }
}
