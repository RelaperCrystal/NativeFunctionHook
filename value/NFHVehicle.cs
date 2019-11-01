using GTA;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeFunctionHook.value
{
    public class NFHVehicle
    {
        public Vehicle GTAVehicle { get; private set; }
        
        public NFHVehicle(Vehicle car)
        {
            GTAVehicle = car;
        }
        
        /// <summary>
        /// Get or set the value of light is ON or OFF.
        /// </summary>
        public bool TaxiLight
        {
            get
            {
                return Function.Call<bool>("ARE_TAXI_LIGHTS_ON", GTAVehicle);
            }
            set
            {
                int temp;
                temp = Common.ConvertBoolToInt(value);
                Function.Call("SET_TAXI_LIGHTS", new Parameter[] {
                    GTAVehicle,
                    temp
                });
            }
        }

        /// <summary>
        /// Set is the car can be visibly damaged or not.
        /// </summary>
        public bool CanBeVisiblyDamaged
        {
            set
            {
                Function.Call("SET_CAR_CAN_BE_VISIBLY_DAMAGED", new Parameter[] {
                    GTAVehicle,
                    value
                });
            }
        }

        /// <summary>
        /// Set is the car can be damaged or not.
        /// </summary>
        public bool CanBeDamaged
        {
            set
            {
                Function.Call("SET_CAR_CAN_BE_DAMAGED", new Parameter[] {
                    GTAVehicle,
                    value
                });
            }
        }

        /// <summary>
        /// Get the health of the siren, on emergency vehicles.
        /// </summary>
        public int SirenHealth
        {
            get
            {
                return Function.Call<int>("GET_CAR_SIREN_HEALTH", GTAVehicle);
            }
        }
    
    }
}
