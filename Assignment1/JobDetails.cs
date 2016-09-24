// This assigment is for implementing Inheritance and Interface

using System;

namespace Assignment1
{
    class JobDetails
    {
        public string Organization = "Google";
        protected string Login = "Sid123";
        protected string Password = "abc123";
        protected int JobID = 12345;
        protected string Position = "Developer";
        protected string Location = "Houston";
        protected DateTime Date = default(DateTime);


        static void Main(string[] args)
        {
           
            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Insert Job Details");
            Console.WriteLine("2. Search the Job Details");
            Console.WriteLine("3. See Report");
            string choice = Console.ReadLine();
            int check = Convert.ToInt32(choice);

            do
            {
                switch (choice)
                {
                    case "1":
                        InsertData ID = new InsertData();
                        ID.IPrint("siddhu");
                        break;
                    case "2":
                        Search SC = new Search();
                        SC.IPrint("ani");
                        break;
                    case "3":
                        SeeReport SR = new SeeReport();
                        SR.IPrint("Chanchad");
                        break;
                    default:
                        Console.WriteLine("Enter a correct Value");
                        break;
                }

            } while (check < 3);
    }
    }

    class InsertData : JobDetails, IDisplay
    {


        public void IPrint(string msg)
        {
            Console.WriteLine("The data inserted is: \n" + Organization + " , " + Login + " , " + Password + " , " + JobID + " , " + Position + " , " + Location + " , " + Date);
            Console.ReadKey();
        }
    }
}
