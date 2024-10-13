using HarmonyLib;
using RST;
using RST.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EnableCheat
{
    [HarmonyPatch(typeof(PlayMakerGUI), nameof(PlayMakerGUI.Awake))]
    public static class PlaymakerGui_AddCheatUi
    {
        public static void Prefix(PlayMakerGUI __instance)
        {
            if (__instance.GetComponent<Cheatcodes>() != null) return;

            Cheatcodes cheatcodes = __instance.gameObject.AddComponent<Cheatcodes>();
            
            //Can't find the prefab needed by the Cheatcodes object.  Maybe not included in the
            //  release version? 

            //cheatcodes.showMutexesPrefab = UnityEngine.Resources
            //    .FindObjectsOfTypeAll<RST.UI.ShowMutexes>()
            //    .FirstOrDefault();

            Cheatcodes.Instance = cheatcodes;


           
        }
    }
}
