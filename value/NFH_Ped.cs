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

        /// <summary>
        /// Sets ped preform ragdoll or not when facing player impact.
        /// </summary>
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

        /// <summary>
        /// Forces ped to drop weapon.
        /// </summary>
        public void ForceToDropWeapon()
        {
            Function.Call("FORCE_CHAR_TO_DROP_WEAPON", GTAPed);
        }

        /// <summary>
        /// Sets the alpha of the ped.
        /// </summary>
        public int Alpha
        {
            set
            {
                Functions.InternalSetPedAlpha(this.GTAPed, value);
            }
        }

        /// <summary>
        /// Sets the ped can preform ambient anims or not.
        /// </summary>
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

        [Obsolete("It's dangerous to call this property.", true)]
        public unsafe bool AmbientAnimGroup
        {
            set
            {
                Function.Call("SET_ANIM_GROUP_FOR_CHAR", new Parameter[] {
                    GTAPed,
                    value
                });
            }
        }

        /// <summary>
        /// Add or remove the ped from mission deletion list.
        /// </summary>
        /// <param name="AddOrRemove">If true, add to list. If false, remove from list.</param>
        public void AddToMissionDeletionList(bool AddOrRemove)
        {
            Function.Call("ADD_PED_TO_MISSION_DELETION_LIST", new Parameter[] {
                GTAPed,
                AddOrRemove
            });
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
