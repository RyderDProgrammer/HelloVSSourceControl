using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVSSourceControl
{
    /// <summary>
    /// Represents a single vehicle
    /// with the number in stock
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// The make of the vehicle.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The type of vehicle that it is.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// How many are in stock
        /// </summary>
        public byte Quantity { get; set; }
    }
}
