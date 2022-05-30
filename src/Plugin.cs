﻿using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// RENAME 'Dszecore' TO SOMETHING ELSE
namespace Dszecore
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        // Choose a GUID for your project. Change "myname" and "mymod".
        public const string GUID = "dsze.core";
        // Choose a NAME for your project, generally the same as your Assembly Name.
        public const string NAME = "Dszecore";
        // Increment the VERSION when you release a new version of your mod.
        public const string VERSION = "0.1.0";

        // For accessing your BepInEx Logger from outside of this class (eg Plugin.Log.LogMessage("");)
        internal static ManualLogSource Log;

        // If you need settings, define them like so:
        public static ConfigEntry<bool> ExampleConfig;

        // Awake is called when your plugin is created. Use this to set up your mod.
        internal void Awake()
        {
            // Harmony is for patching methods. If you're not patching anything, you can comment-out or delete this line.
            new Harmony(GUID).PatchAll();
        }

        // Update is called once per frame. Use this only if needed.
        // You also have all other MonoBehaviour methods available (OnGUI, etc)
        internal void Update()
        {

        }

        // This is an example of a Harmony patch.
        // If you're not using this, you should delete it.
        [HarmonyPatch(typeof(ResourcesPrefabManager), nameof(ResourcesPrefabManager.Load))]
        public class ResourcesPrefabManager_Load
        {
            static void Postfix()
            {
                // This is a "Postfix" (runs after original) on ResourcesPrefabManager.Load
                // For more documentation on Harmony, see the Harmony Wiki.
                // https://harmony.pardeike.net/
            }
        }
    }
}
