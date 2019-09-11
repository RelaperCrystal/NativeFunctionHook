using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;
using GTA.Native;

namespace NativeFunctionHook.value
{
    public class NFH_Ped
    {
        public NFH_Ped(Ped ped)
        {
            GTAPed = ped;
        }
        public Ped GTAPed { get; private set; }

        /// <summary>
        /// It returns the handle of the object ped is holding.
        /// A test of SHDN is it could convert returned handle into a <see cref="GTA.Object"/>.
        /// </summary>
        /// <returns></returns>
        public GTA.Object GetObjectPedIsHolding()
        {
            return Function.Call<GTA.Object>("GET_OBJECT_PED_IS_HOLDING", this.GTAPed);
        }

        public bool PreventPlayerBumpRagdoll
        {
            set
            {
                Function.Call("SET_DONT_ACTIVATE_RAGDOLL_FROM_PLAYER_IMPACT", new Parameter[] {
                    GTAPed,
                    value
                });
            }
        }

        public bool BlockAmbientAnims
        {
            set
            {
                Function.Call("BLOCK_CHAR_AMBIENT_ANIMS", new Parameter[] {
                    GTAPed,
                    value
                });
            }
        }

        public bool AmbientAnimGroup
        {
            set
            {
                Function.Call("SET_ANIM_GROUP_FOR_CHAR", new Parameter[] {
                    GTAPed,
                    value
                });
            }
        }

        public int CurrentWeaponID
        {
            set
            {
                Function.Call("SET_CURRENT_CHAR_WEAPON", new Parameter[] {
                    GTAPed,
                    value
                });
            }
        }
    }
}
