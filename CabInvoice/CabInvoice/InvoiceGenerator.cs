using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    public class InvoiceGenerator
    {
        //Variables
        public double distance;
        public int Time;
        public double[] rides;
        public double TotalFare;
        public double AvgFare;
        public int NumberOfRides;
        //Constants
        private readonly double COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;
        /// <summary>
        /// Constuctor for declaring values for constancts
        /// </summary>
        public InvoiceGenerator()
        {
            COST_PER_KM = 10;
            COST_PER_TIME = 1;
            MINIMUM_FARE = 5;
        }
        /// <summary>
        /// Method to calculate fare
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public double CalculateFare(double distance,int Time)
        {
            double totalfare = 0;
            totalfare = distance * COST_PER_KM + Time * COST_PER_TIME;
            return totalfare;
        }
        /// <summary>
        /// Method to calculate multiple rides
        /// </summary>
        /// <param name="ride"></param>
        /// <returns></returns>
        public double CalculateFare(Rides[] ride)
        {
            double totalfare = 0;
            foreach(Rides rides in ride)
            {
                totalfare = totalfare + CalculateFare(rides.distance,rides.time);
            }
            return totalfare;
        }
    }
}
