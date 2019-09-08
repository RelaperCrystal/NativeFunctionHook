using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;
using GTA.Native;

namespace NativeFunctionHook.MissionCtrl
{
    public class NMission
    {
        /// <summary>
        /// Defines the <see cref="Ped"/>s of this mission.
        /// </summary>
        private List<Ped> missionPeds;
        /// <summary>
        /// Defines the <see cref="Vehicle"/>s of this mission.
        /// </summary>
        private List<Vehicle> missionVehicles;
        /// <summary>
        /// Defines the <see cref="GTA.Object"/>s of this mission.
        /// </summary>
        private List<GTA.Object> missionObjs;

        /// <summary>
        /// Defines the destination <see cref="Blip"/> of this mission.
        /// </summary>
        public Blip missionTarget { get; private set; }

        /// <summary>
        /// Defines the NMission name, reserved for later use.
        /// </summary>
        public string MissionName { get; private set; }

        /// <summary>
        /// Defines what ID will be used when calling <see cref="NAudio.TriggerMissionCompleteSFX(int)"/>, on mission passed.
        /// </summary>
        public int MissionCompleteSFXVal { get; private set; }

        /// <summary>
        /// Create a new instance of <see cref="NMission"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="CompleteSFX_ID"></param>
        public NMission(string name, int CompleteSFX_ID)
        {
            MissionName = name;
            MissionCompleteSFXVal = CompleteSFX_ID;
        }
    }
}
