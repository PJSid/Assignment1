using System;

namespace Assignment1
{
    class SeeReport:JobDetails,IDisplay
    {
        public SeeReport()
        {
            Organization = "Google";
            Login = "sid123";
            Password = "abc123";
            JobID = 9876;
            Location = "texas";
            Position = ".Net Developer";
                     
        }

        public void IPrint(string msg)
        {
            Console.Write("The SeeReport Results are: \n" + "Organization: " + Organization +"\n" + "Login: " + Login + "\n Password: " + Password + "\n JobId: " + JobID + "\n Location: " + Location + "\n Position: " + Position + "\n Date: " + Date);
            Console.ReadKey();
        }
    }
}
