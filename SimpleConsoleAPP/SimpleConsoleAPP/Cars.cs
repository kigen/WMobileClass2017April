using System;

namespace SimpleConsoleAPP
{
     class Cars
    {

         public Cars()
         {
             seats = 4;
         }
         public string Make { get; set; }
         public string Model { get; set; }
         public int YearOfManufacture { get; set; }

         private int seats;
         public int Seats
         {
             get { return seats; }
         }

         public void PrintReport()
         {
             //prints out a report about the car. 
             Console.WriteLine("The car Make is:{0}", this.Make);
             Console.WriteLine("The car Model is:{0}", this.Model);
             Console.WriteLine("The car was manaufactured in {0}", this.YearOfManufacture);
         }
    }
}
