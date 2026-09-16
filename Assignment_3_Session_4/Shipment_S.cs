using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Session_4
{
    internal struct Shipment
    {
        // Private fields
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;

        // TrackingCode: read-only from outside
        public string TrackingCode
        {
            get { return _trackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        // Description: read/write with validation
        public string Description
        {
            get { return _description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        // Weight: read/write with validation
        public decimal Weight
        {
            get { return _weight; }

            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        // DeliveryFee: public getter, private setter
        public decimal DeliveryFee
        {
            get { return _deliveryFee; }

            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        // Destination: public read/write property
        public DeliveryAddress_S Destination { get; set; }

        // Calculated property - no separate field
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        // Constructor 1: receives trackingCode only
        public Shipment(string trackingCode)
        {
            // Start with valid default values
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            Destination = new DeliveryAddress_S();

            // Change tracking code only if valid
            TrackingCode = trackingCode;
        }

        // Constructor 2
        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress_S destination)
        {
            // Start with valid default values
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            Destination = destination;

            // Use properties so validation is applied
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        // Update delivery fee only if newFee > 0
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        // Print all shipment information
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }
}
