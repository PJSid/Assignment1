using System;

namespace Assignment1
{
    class Search :JobDetails,IDisplay
    {
        private string ByName { get; set; }
        private string ByLocation { get; set; }
        private int ByID { get; set; }

        public Search()
        {
            ByName = Organization;
            ByLocation = Location;
            ByID = JobID;
        }

        public void IPrint(string msg)
        {
            Console.Write("Search results are: Search by Organization: " + ByName + "\n Search By Location:" + ByLocation + "\n Search by JobID:" + ByID);
            Console.ReadKey();
        }
    }
}
