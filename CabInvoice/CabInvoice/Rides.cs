using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    public class Rides
    {
        //Variables
        public double distance;
        public int time;
        /// <summary>
        /// Default constructor for passing distance and time
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Rides(double distance, int time)
        {
            this.time = time;
            this.distance = distance;
        }
    }
}
