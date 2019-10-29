using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA.Native;
using GTA;

namespace NativeFunctionHook
{
    public class NWorld
    {
        /// <summary>
        /// Get all injured ped number in range.
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="Range"></param>
        /// <returns></returns>
        public static int GetInjuredPedInRange(Vector3 pos, float Range)
        {
            int result = Function.Call<int>("GET_NUMBER_OF_INJURED_PEDS_IN_RANGE", new Parameter[]{
            pos.X, pos.Y, pos.Z, Range
            });
            return result;
        }

        /// <summary>
        /// Adds a Police Station spawn point when the player gets busted.
        /// </summary>
        /// <param name="Position">The coordinates of spawnpoint.</param>
        /// <param name="Facing">Facing when player respawn.</param>
        /// <param name="StationID">Police Station ID.</param>
        public static void AddBustedRespawnPoint(Vector3 Position, float Facing, int StationID)
        {
            float X = Position.X;
            float Y = Position.Y;
            float Z = Position.Z;
            Function.Call("ADD_POLICE_RESTART", new Parameter[]{
                X, Y, Z, Facing, StationID
            });
        }

        /// <summary>
        /// This function adds a string to the news scrollbar as seen in The Triangle, south of Star Junction.
        /// The news scrollbar in northern Star Junction is controlled by scrollbars.dat. 
        /// Recommonded to call <see cref="ClearNewsScrollBar()"/> before calling this function. If you don't, 
        /// the string will be added next to the previous one that was created.
        /// </summary>
        /// <param name="text"></param>
        public static void AddStringToNewsScrollBar(string text)
        {
            Function.Call("ADD_STRING_TO_NEWS_SCROLLBAR", new Parameter[]{
                text
            });
        }

        /// <summary>
        /// This function removes all text on the news scrollbar as seen in The Triangle, south of Star Junction.
        /// The news scrollbar in northern Star Junction is controlled by scrollbars.dat. 
        /// </summary>
        /// <param name="text"></param>
        public static void ClearNewsScrollBar(string text)
        {
            Function.Call("CLEAR_NEWS_SCROLLBAR");
        }
        
        /// <summary>
        /// Draws a checkpoint at the specified coordinates, with the specified radius, 
        /// with the specified color (RGB). Must be used in a thread (cycle)!!
        /// </summary>
        /// <param name="position">The position of checkpoint needed to be draw.</param>
        /// <param name="radius">The radius of the checkpoint.</param>
        /// <param name="R">The color value of Red, in RGB color.</param>
        /// <param name="G">The color value of Green, in RGB color.</param>
        /// <param name="B">The color value of Blue, in RGB color.</param>
        public static void DrawCheckpoint(Vector3 position, float radius, value.RGBColor clr)
        {
            Function.Call("DRAW_CHECKPOINT", new Parameter[]{
                position.X, position.Y, position.Z, radius, clr.R, clr.G, clr.B
            });
        }

        public static void DrawColouredArrow(Vector3 position, value.RGBColor clr)
        {
            Function.Call("DRAW_COLOURED_CYLINDER", new Parameter[]
            {
                position.X,
                position.Y,
                position.Z,
                -2,
                0.8,
                clr.R,
                clr.G,
                clr.B,
                0
            });
        }
        public const float Radius_Checkpoint_Arrow = 7f;
    }
}
