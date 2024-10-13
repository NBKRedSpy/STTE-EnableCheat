using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EnableCheat
{

    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static string ModAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;

        public static ManualLogSource Log { get; set; }

        public static ConfigEntry<KeyboardShortcut> EnableCheatKeys { get; private set; }

        private void Awake()
        {
            Log = Logger;

            EnableCheatKeys = Config.Bind("Options", nameof(EnableCheatKeys), new KeyboardShortcut(KeyCode.RightBracket, KeyCode.LeftControl),"The keys to hold down to enable the cheats.");

            Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }
    }
}
