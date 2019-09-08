using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;
using GTA.Native;

namespace NativeFunctionHook.value
{
    public class NPlayer
    {
        /// <summary>
        /// Returns a boolean indicating if the specified player is pressing the cars horn.
        /// </summary>
        /// <param name="index">Index ID. Is</param>
        public static bool IsPlayerPressingHorn(int index)
        {
            return Function.Call<bool>("IS_PLAYER_PRESSING_HORN", index);
        }

        /// <summary>
        /// Convert the meanless player ID to Player Index.
        /// </summary>
        /// <param name="ID">Player ID.</param>
        /// <returns>Player Index.</returns>
        public static int ConvertPlayerIDToIndex(int ID)
        {
            int result = Function.Call<int>("CONVERT_INT_TO_PLAYERINDEX", ID);
            return result;
        }

        /// <summary>
        /// Returns the Current Player's ID. 
        /// The Player ID is meaningless for other script functions and should be converted to a Player Index.
        /// </summary>
        /// <returns>Player ID.</returns>
        public static int GetPlayerId()
        {
            int result = Function.Call<int>("GET_PLAYER_ID");
            return result;
        }

        /// <summary>
        /// This function returns true if the player is targetting a ped.
        /// </summary>
        /// <param name="index">Player Index.</param>
        /// <returns>Returns true if player is targetting a ped.</returns>
        public static bool IsPlayerTargettingPed(int index)
        {
            return Function.Call<bool>("IS_PLAYER_TARGETTING_CHAR", index);
        }

        /// <summary>
        /// Switch ON or OFF for prevent cops from spawning when the player is wanted.
        /// </summary>
        /// <param name="index">Player Index.</param>
        /// <param name="val">Whether to prevent cops from spawning when the player is wanted</param>
        public static void SwitchDispatchCopForPlayerWhenWanted(int index, bool val)
        {
            Function.Call("DONT_DISPATCH_COPS_FOR_PLAYER", new Parameter[] {
                index, val
            });
        }

        /// <summary>
        /// Get the time since play last time of busted.
        /// </summary>
        public static int TimeSincePlayerLastArrested
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_LAST_ARREST", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time of wasted.
        /// </summary>
        public static int TimeSincePlayerLastDied
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_LAST_DEATH", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time of Drove Against the Traffic.
        /// </summary>
        public static int TimeSincePlayerLastDroveAgainstTraffic
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_DROVE_AGAINST_TRAFFIC", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time of Drove on Pavement.
        /// </summary>
        public static int TimeSincePlayerLastDroveOnPavement
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_DROVE_ON_PAVEMENT", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time hit a building.
        /// </summary>
        public static int TimeSincePlayerLastHitBuilding
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_HIT_BUILDING", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time hit a car.
        /// </summary>
        public static int TimeSincePlayerLastHitCar
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_HIT_CAR", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time hit a object.
        /// </summary>
        public static int TimeSincePlayerLastHitObject
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_HIT_OBJECT", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time hit a ped.
        /// </summary>
        public static int TimeSincePlayerLastHitPed
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_HIT_PED", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }

        /// <summary>
        /// Get the time since player last time ran a red light.
        /// </summary>
        public static int TimeSincePlayerLastRanLight
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_PLAYER_RAN_LIGHT", ConvertPlayerIDToIndex(GetPlayerId()));
                return result;
            }
        }
    }
}
