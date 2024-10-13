using BepInEx.Configuration;
using HarmonyLib;
using RST;
using RST.PlaymakerAction;
using RST.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EnableCheat
{

    /// <summary>
    /// Changes the cheat codes system to look for a hotkey instead of requiring a special
    /// string of characters.
    /// </summary>
    [HarmonyPatch(typeof(Cheatcodes), nameof(Cheatcodes.Update))]
    public static class Cheatcodes_Update_Patch
    {
        public static bool Prefix(Cheatcodes __instance)
        {

            //Note:
            //This code is based on the game's original code:
            //
            //  if (cnt >= cheatEnable.Length)
            //  {
            //        cnt = 0;
            //      CheatsEnabled = true;
            //      SpawnUiPrefab("{0} enabled cheats");
            //      SectorSelection.canStartFromAnySector = true;
            //      ShowMutexes(show: true);
            //  }

            //I was unable to find the ShowMutexes prefab or the onKeypressSpawnUiPrefab which is 
            //required by the SpawnUiPrefab and the ShowMutexes code. 
            //So this code does not call the functions that require those items.
            //The impact is that any cheats that use the UI based cheats will not execute.

            if(Plugin.EnableCheatKeys.Value.IsUp())
            {
                //Toggle the cheats.
                __instance.CheatsEnabled = !__instance.CheatsEnabled;
                SectorSelection.canStartFromAnySector = __instance.CheatsEnabled;

                //When toggling to enabled, wait for the next Update as the game's base code does.
                if (__instance.CheatsEnabled) return false;
            }

            //If disabled, do not run the game's "magic string to enable" code.
            //If enabled, call the original code to handle any cheat hotkeys.
            return __instance.CheatsEnabled;
        }
    }

}
