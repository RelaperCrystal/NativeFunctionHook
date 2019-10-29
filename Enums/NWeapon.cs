using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeFunctionHook.Enums
{
    /// <summary>
    /// The NFH Weapon enum.
    /// </summary>
    public enum NWeapon
    {
        /// <summary>
        /// Fist.
        /// </summary>
        Unarmed = 0,
        Melee_BaseballBat = 1,
        Melee_Poolcue = 2,
        Melee_Knife = 3,
        Thrown_Granade = 4,
        Thrown_Molotov = 5,
        /// <summary>
        /// One of <see cref="Heavy_Rocket"/> or <see cref="Heavy_RocketLauncher"/> is not usable by player - 
        /// It WILL CAUSE CRASH OF THE GAME.
        /// </summary>
        Heavy_Rocket = 6,
        Handgun_Glock = 7,
        /// <summary>
        /// This slot of weapon, used by LCPD:FR, is LCPDFR Taser.
        /// </summary>
        Handgun_Unused0 = 8,
        Handgun_Deagle = 9,
        /// <summary>
        /// The sawn-off pump shotgun.
        /// </summary>
        Shotgun_Basic = 10,
        /// <summary>
        /// The long shotgun.
        /// </summary>
        Shotgun_Baretta = 11,
        /// <summary>
        /// The Mirco UZI.
        /// </summary>
        SMG_MicroUZI = 12,
        /// <summary>
        /// The MP5.
        /// </summary>
        SMG_MP5 = 13,
        AssualtRifle_M4 = 14,
        AssualtRifle_AK47 = 15,
        /// <summary>
        /// The Normal sniper rifle, or PTG1.
        /// </summary>
        Heavy_SniperRifle = 16,
        Heavy_M40AI = 17,
        /// <summary>
        /// One of <see cref="Heavy_Rocket"/> or <see cref="Heavy_RocketLauncher"/> is not usable by player - 
        /// It WILL CAUSE CRASH OF THE GAME.
        /// </summary>
        Heavy_RocketLauncher = 18,
        /// <summary>
        /// It is unused and will cause crash of the game.
        /// Unlike <see cref="Handgun_Unused0"/>, it is not used by any of mods.
        /// </summary>
        Unused_FlameThrower = 19,
        /// <summary>
        /// It is unused and will cause crash of the game.
        /// Unlike <see cref="Handgun_Unused0"/>, it is not used by any of mods.
        /// </summary>
        Unused_Minigun = 20,
        /// <summary>
        /// The camera. It is used only by peds, giving it to player will cause crash of the game.
        /// If you want to give it to player, consider spawn it as single object and attach it to player's hand.
        /// </summary>
        Object_Camera = 45,
        /// <summary>
        /// Any of throwable objects.
        /// </summary>
        Object_AnyMapObj = 46,
        Misc_LastType = 47,
        Misc_Armour = 48,
        Selection_AnyMelee = 57,
        Selection_AnyWeapon = 58
    }
    public enum NDamagedBy
    {
        /// <summary>
        /// One single hit by car causing died.
        /// </summary>
        DamagedBy_RammedByCar = 49,
        /// <summary>
        /// Runned over by car causing died.
        /// </summary>
        DamagedBy_RunoverByCar = 50,
        /// <summary>
        /// Explosion caused by car explode, etc. ambient / accidently explosion.
        /// </summary>
        DamagedBy_Explosion = 51,
        /// <summary>
        /// Shot by SMG drive by.
        /// </summary>
        DamagedBy_UziDriveBy = 52,
        /// <summary>
        /// Drowned in water.
        /// </summary>
        DamagedBy_Drowning = 53,
        /// <summary>
        /// Died by high velocity impact. Sometimes, it is not caused by falling,
        /// It happens when ped died by <see cref="DamagedBy_Unidentified"/> falling on ground.
        /// </summary>
        DamagedBy_Falling = 54,
        /// <summary>
        /// Unknown reason to die.
        /// </summary>
        DamagedBy_Unidentified = 55,
        /// <summary>
        /// Killed by either unarmed or using melee weapon.
        /// </summary>
        DamagedBy_Melee = 56
    }
    public enum NEpisodicWeapons
    {
        Episodic_1 = 21,
        Episodic_2 = 22,
        Episodic_3 = 23,
        Episodic_4 = 24,
        Episodic_5 = 25,
        Episodic_6 = 26,
        Episodic_7 = 27,
        Episodic_8 = 28,
        Episodic_9 = 29,
        Episodic_10 = 30,
        Episodic_11 = 31,
        Episodic_12 = 32,
        Episodic_13 = 33,
        Episodic_14 = 34,
        Episodic_15 = 35,
        Episodic_16 = 36,
        Episodic_17 = 37,
        Episodic_18 = 38,
        Episodic_19 = 39,
        Episodic_20 = 40,
        Episodic_21 = 41,
        Episodic_22 = 42,
        Episodic_23 = 43,
        Episodic_24 = 44
    }
}
