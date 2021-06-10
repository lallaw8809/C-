using System;

namespace Program
{
    class Properties
    {
        class Cricket
        {
            private int totalMatches;
            private int odiScroes;
            public int age;

            // Properties with read and write
            public int setNumOfMatches
            {
                set
                {
                    if (value > 0) this.totalMatches = value;
                    else throw new Exception("Invalid score");
                }

                get { return this.totalMatches; }
            }
 
            //  Expression-body definition
            public int internationalODIScores
            {
                
                set => odiScroes = value;
                get => odiScroes;
            }

            // Auto-implemented method
            public decimal highestScroes
            { get; set; }

            // Properties with Read only
            public string Name => "Saurav Ganguly";

            // Another way to implement this method for to set the name
            // public string Name
            //{
            //    get { return "Saurav"; }
            //}

            // Properties with write only
            public int setAge
            {
                set { this.age = value; }
            }
        }
        
        static void Main(string[] args)
        {
            Cricket player = new Cricket();

            // Write/assign the vaulue to the properties (set accessor will get called)
            player.setNumOfMatches = 351;
            player.internationalODIScores = 11000;
            player.highestScroes = 181;
            player.age = 45;

            // Read the properties (get accessor will get called)
            Console.WriteLine("{0} who is {1} years old and he has played {2} matches", player.Name, player.age, player.setNumOfMatches);       
            Console.WriteLine("He has scroed {0} runs with highest score of {1}", player.internationalODIScores, player.highestScroes);

            // Can not write the Name as its readonly properties
            // player.Name = "Sachin";

            // Can not read the setAge properties as its a write only properties
            // Console.WriteLine("{0}", player.setAge);
        }
    }
}
