using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA.Native;

namespace NativeFunctionHook.DebuggerConsole
{
    public class RDbg
    {
        /// <summary>
        /// It does nothing on production version.
        /// It could show a message box, with Retry, Ignore, Cancel button.
        /// </summary>
        /// <param name="info">The info wants to show.</param>
        public static void ScriptAssert(string info)
        {
            Function.Call("SCRIPT_ASSERT", info);
        }

        /// <summary>
        /// It does nothing on production version.
        /// It could print a line of text on the debugger console.
        /// </summary>
        /// <param name="info"></param>
        public static void PrintStringOnDbgCsl(string info)
        {
            Function.Call("PRINTSTRING", info);
        }

        /// <summary>
        /// It does nothing but returns "Debug command not in final build".
        /// It could show the model name.
        /// </summary>
        /// <returns>A <see cref="String"/>: "Debug command not in final build"</returns>
        public static string GetModelNameForDebug()
        {
            return Function.Call<string>("GET_MODEL_NAME_FOR_DEBUG");
        }
    }
}
