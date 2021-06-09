using System;

namespace Program
{
    class Properties
    {
        class Office
        {
            private string officeName = string.Empty;
            public int officeOpenTime;

            // Properties with read and write
            public int setTime
            {
                set
                {
                    if (value >= 8 && value <= 17)
                    {
                        this.officeOpenTime = value;
                    }
                    else
                    {
                        throw new Exception("Office is not opened at this time");
                    }
                }

                get
                {
                    return this.officeOpenTime;
                }
            }
            
            //  Expression-bodied member method
            public string setName
            {
                
                set => officeName = value;
                get => officeName;
            }

            // Auto-implemented method
            public decimal Price
            { get; set; }

            // Properties with Read only

            // Properties with write only
        }
        
        static void Main(string[] args)
        {
            Office openTime = new Office();
            openTime.setTime = 18; // Set the time (set properties will get called)

            Console.WriteLine("The office open at {0}", openTime.setTime); // get properties will get called
            openTime.setName = "Phonak";
            Console.WriteLine("The office open at {0}", openTime.setName); // get properties will get called

        }
    }
}
