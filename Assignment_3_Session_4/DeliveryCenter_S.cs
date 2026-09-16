using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Session_4
{
    internal class DeliveryCenter_S
    {
        // Stores a maximum of 10 shipments
        private Shipment[] _shipments;

        // Constructor
        public DeliveryCenter_S()
        {
            _shipments = new Shipment[10];
        }

        // Integer indexer
        public Shipment this[int index]
        {
            get
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }

                return default;
            }

            set
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        // String indexer - search by TrackingCode
        public Shipment this[string trackingCode]
        {
            get
            {
                if (_shipments == null)
                {
                    return default;
                }

                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];
                    }
                }

                return default;
            }
        }

        // Add shipment to first available position
        public bool AddShipment(Shipment shipment)
        {
            // In case DeliveryCenter was created using default
            if (_shipments == null)
            {
                _shipments = new Shipment[10];
            }

            for (int i = 0; i < _shipments.Length; i++)
            {
                // A default Shipment has no TrackingCode,
                // so this position is considered empty.
                if (string.IsNullOrWhiteSpace(_shipments[i].TrackingCode))
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }

            // No available position
            return false;
        }
    }
}
