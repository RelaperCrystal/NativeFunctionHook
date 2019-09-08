using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;

namespace NativeFunctionHook.value
{
    /// <summary>
    /// A checkpoint. Unless <see cref="Checkpoint"/>, this checkpoint allows to see an Arrow, but still WIP. Detection are
    /// also included.
    /// </summary>
    public class NCheckpoint
    {
        /// <summary>
        /// Defines the <see cref="Vector3"/> position of the Checkpoint.
        /// </summary>
        public Vector3 Position { get; private set; }

        /// <summary>
        /// Defines the diameter size of the Checkpoint.
        /// </summary>
        public float Diameter { get; private set; }

        private Timer time;
        /// <summary>
        /// Creates an new instance of <see cref="NCheckpoint"/>.
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="dia"></param>
        public NCheckpoint(Vector3 pos, float dia)
        {
            Position = pos;
            Diameter = dia;
        }

        private void Draw()
        {
            
        }

    }
}
