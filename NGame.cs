using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA.Native;

namespace NativeFunctionHook
{
    public class NGame
    {
        /// <summary>
        /// Returns the Current Player's ID. 
        /// The Player ID is meaningless for other script functions and should be converted to a Player Index.
        /// </summary>
        /// <returns>Player ID.</returns>
        [Obsolete("Should use the one from value.NPlayer")]
        public static int GetPlayerId()
        {
            int result = Function.Call<int>("GET_PLAYER_ID");
            return result;
        }

        /// <summary>
        /// Get the time since play last time of busted.
        /// </summary>
        public static int TimeSincePlayerLastArrested
        {
            get
            {
                int result = Function.Call<int>("GET_TIME_SINCE_LAST_ARREST");
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
                int result = Function.Call<int>("GET_TIME_SINCE_LAST_DEATH");
                return result;
            }
        }

        /// <summary>
        /// Removes the player's current prostitute. Used before initiating a date.
        /// Use with caution.
        /// </summary>
        public static void RemovePlayerProstitute()
        {
            Function.Call("GET_RID_OF_PLAYER_PROSTITUTE");
        }

        /// <summary>
        /// Print a text on subtitle position, at bottom of the screen.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="duration"></param>
        public static void PrintSubtitle(string text, int duration = 7000)
        {
            Function.Call("PRINT_STRING_WITH_LITERAL_STRING_NOW", new Parameter[] { "STRING", text, duration });
        }

        /// <summary>
        /// Is text in language file being displayed.
        /// </summary>
        /// <param name="langText">The Text ID.</param>
        /// <returns></returns>
        public static bool IsHelpMessageBeingDisplayed(string langText)
        {
            return Function.Call<bool>("IS_THIS_HELP_MESSAGE_BEING_DISPLAYED", new Parameter[] {
                langText
            });
        }

        /// <summary>
        /// Request model. Called for safety etc.
        /// </summary>
        /// <param name="modelHash">The Model hash.</param>
        public static void RequestModel(int modelHash)
        {
            Function.Call("REQUEST_MODEL", modelHash);
        }

        /// <summary>
        /// Request anims. Called for using them in native functions.
        /// </summary>
        /// <param name="animID">The Anim string ID.</param>
        public static void RequestAnims(string animID)
        {
            Function.Call("REQUEST_ANIMS", animID);
        }

        /// <summary>
        /// Sets the game forcing telescope cam or not.
        /// </summary>
        /// <param name="Switch">ON or OFF.</param>
        public static void ForceTelescopeCam(bool Switch)
        {
            Function.Call("FORCE_GAME_TELESCOPE_CAM", Switch);
        }
    }
}
