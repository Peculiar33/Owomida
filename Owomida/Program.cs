namespace Owomida
{
        internal class Driver
        {

            public string Owomida()
            {
                Console.WriteLine("What type of vehicle do you drive?");
                Console.WriteLine("Big Bus,Small Bus,Keke,Car");
                string vehicleType = Console.ReadLine();

            vehicleType = ("Vtype");
                {
                vehicleType = "Big bus";
                        return "500";

                   vehicleType = "Small bus";
                        return "300";

                    vehicleType ="Keke";
                        return "200";

                     vehicleType = "BRT";
                        return "1000";

                        Console.WriteLine("Wrong Input");
                        return "0";
                }
            }

            public double Membership()
            {
            Console.WriteLine("Are you a member of NURTW? - True or Fasle");
                string MembershipType = Console.ReadLine();

                switch (MembershipType)
                {
                    case "True":
                        return 0.7;

                    case "Fasle":
                        return 1;
                    default:
                        return 1;
                }

            }

            public string CalculateFee()
            {
                double totalFee = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"For driver {i + 1} \n");
                    Console.WriteLine("Enter number of trips\n");
                    string trips = Console.ReadLine();
                    int numOfTrips;
                    int.TryParse(trips, out numOfTrips);

                    double discount = Membership();
                    double vehicleFee = Convert.ToDouble("VehicleFee()");

                    double total = numOfTrips * discount * vehicleFee;
                    Console.WriteLine($"The total for driver {i + 1} is {total}");
                    totalFee += total;

                }
                return "The total fee is " + totalFee;
            }
        }
}
