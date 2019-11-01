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

        public static void OpenGarage(string name)
        {
            Functions.InternalOpenGarage(name);
        }

        public static void ClearArea(ClearType type, Vector3 position, float radius)
        {
            if(position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            Functions.InternalClearArea(type, position, radius);
        }

        public static int DayOfWeek
        {
            get
            {
                return Function.Call<int>("GET_CURRENT_DAY_OF_WEEK");
            }
        }

        /// <summary>
        /// Add a stunt jump.
        /// </summary>
        /// <param name="startMinimum">The minimum position of start.</param>
        /// <param name="startMaximum">The maximum position of start.</param>
        /// <param name="landingMinimum">The minimum position of landing.</param>
        /// <param name="landingMaximum">The maximum position of landing.</param>
        /// <param name="cameraPos">The position of camera.</param>
        /// <param name="cashReward">The reward.</param>
        public static void AddStuntJump(Vector3 startMinimum, Vector3 startMaximum, Vector3 landingMinimum, Vector3 landingMaximum, Vector3 cameraPos, int cashReward)
        {
            Function.Call("ADD_STUNT_JUMP", new Parameter[] {
                startMinimum.X, startMinimum.Y, startMinimum.Z,
                startMaximum.X, startMaximum.Y, startMaximum.Z,
                landingMinimum.X, landingMinimum.Y, landingMinimum.Z,
                landingMaximum.X, landingMaximum.Y, landingMaximum.Z,
                cameraPos.X, cameraPos.Y, cameraPos.Z,
                cashReward
            });
        }

        /// <summary>
        /// Result is untested. This was used by TrafficFlow mod.
        /// </summary>
        /// <param name="location">The location when creating the car.</param>
        /// <param name="model">The vehicle model.</param>
        /// <param name="ped1">Out parameter. The pointer of ped 1.</param>
        /// <param name="ped2">Out parameter. The pointer of ped 2.</param>
        /// <param name="vehicle">Out parameter. The pointer of ped 3.</param>
        public static void CreateEmergencyServicesCarThenWalk(Vector3 location, string model, out Pointer ped1, out Pointer ped2, out Pointer vehicle)
        {
            Model modeltmp = new Model(model);
            ped1 = typeof(Ped);
            ped2 = typeof(Ped);
            vehicle = typeof(Vehicle);
            NGame.RequestModel(modeltmp.Hash);
            NGame.RequestModel(Model.CurrentCopModel.Hash);
            Function.Call("CREATE_EMERGENCY_SERVICES_CAR_THEN_WALK", new Parameter[] {
                modeltmp.Hash,
                location.X,
                location.Y,
                location.Z,
                vehicle,
                ped1,
                ped2,
            });
        }

        public const float Radius_Checkpoint_Arrow = 7f;
    }
}
