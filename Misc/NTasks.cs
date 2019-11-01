using GTA;
using GTA.Native;
using NativeFunctionHook.value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeFunctionHook.Misc
{
    public static class NTasks
    {
        /// <summary>
        /// Make first <see cref="Ped"/> to "arrest" second <see cref="Ped"/>.
        /// </summary>
        /// <param name="cop">The "cop". Can be any ped.</param>
        /// <param name="guilty">The "suspect". Can be any ped.</param>
        public static void TaskCharArrestChar(Ped cop, Ped guilty)
        {
            Function.Call("TASK_CHAR_ARREST_CHAR", new Parameter[] {
                cop, guilty
            });
        }

        /// <summary>
        /// Make the first <see cref="NFH_Ped"/> to "arrest" second <see cref="NFH_Ped"/>.
        /// </summary>
        /// <param name="cop">The "cop". Can be any ped.</param>
        /// <param name="guilty">The "suspect". Can be any ped.</param>
        public static void TaskCharArrestChar(NFH_Ped cop, NFH_Ped guilty)
        {
            TaskCharArrestChar(cop.GTAPed, guilty.GTAPed);
        }
    }
}
