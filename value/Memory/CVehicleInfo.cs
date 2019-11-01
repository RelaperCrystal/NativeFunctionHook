using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeFunctionHook.value.Memory
{
    public struct CVehicleInfo
    {
        /// <summary>
        /// Max of 16, the memory stack is 0x0000
        /// </summary>
        public char[] sIdentifier;
        /// <summary>
        /// The memory stack is 0X0010
        /// </summary>
        public float fMass;
        /// <summary>
        /// The memory stack is 0x0020
        /// </summary>
        public float centreOfMassX; //0x0020
        /// <summary>
        /// The memory stack is 0x0024
        /// </summary>       
        public float centreOfMassY; //0x0024
        /// <summary>
        /// The memory stack is 0x0028
        /// </summary>
        public float centreOfMassZ; //0x0028
        /// <summary>
        /// The memory stack is 0x0030
        /// </summary>
        public Int32 nPercentSubmerged;
        /// <summary>
        /// The memory stack is 0X003C
        /// </summary>
        public float m_fDriveInertia; //0x003C
        /// <summary>
        /// The memory stack is 0X0040
        /// </summary>
        public Int16 m_nDriveGears; //0x0040
        /// <summary>
        /// The memory stack is 0X0044
        /// </summary>
        public float m_fDriveForce; //0x0044
        /// <summary>
        /// The memory stack is 0X0074
        /// </summary>
        public float m_fBrakeForce; //0x0074   
        /// <summary>
        /// The memory stack is 0X008C
        /// </summary>
        public float m_fTractionCurveMax; //0x008C
        /// <summary>
        /// The memory stack is 0X0094
        /// </summary>
        public float m_fTractionCurveMin; //0x0094
        /// <summary>
        /// The memory stack is 0X00B4
        /// </summary>
        public float m_fSuspensionForce; //0x00B4
        /// <summary>
        /// The memory stack is 0X00B8
        /// </summary>
        public float m_fSuspensionCompDamp; //0x00B8
        /// <summary>
        /// The memory stack is 0X00BC
        /// </summary>
        public float m_fSuspensionReboundDamp; //0x00BC
        /// <summary>
        /// The memory stack is 0X00C0
        /// </summary>
        public float m_fSuspensionUpperLimit; //0x00C0
        /// <summary>
        /// The memory stack is 0X00C4
        /// </summary>
        public float m_fSuspensionLowerLimit; //0x00C4 
        /// <summary>
        /// The memory stack is 0X00C8
        /// </summary>
        public float m_fSuspensionRaise; //0x00C8
        /// <summary>
        /// The memory stack is 0X00D4
        /// </summary>
        public float m_fCollisionDamageMult; //0x00D4
        /// <summary>
        /// The memory stack is 0X00D8
        /// </summary>
        public float m_fWeaponDamageMult; //0x00D8
        /// <summary>
        /// The memory stack is 0X00DC
        /// </summary>
        public float m_fDeformationDamageMult; //0x00DC
        /// <summary>
        /// The memory stack is 0X00E0
        /// </summary>
        public float m_fEngineDamageMult; //0x00E0
        /// <summary>
        /// The memory stack is 0X00E4
        /// </summary>
        public float m_fSeatOffsetDist; //0x00E4 
    }
}
