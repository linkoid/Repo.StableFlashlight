using BepInEx;
using BepInEx.Logging;
using UnityEngine;
using HarmonyLib;
using System.Linq;
using System.Collections.Generic;

namespace Linkoid.Repo.StableFlashlight;

[BepInPlugin("Linkoid.Repo.StableFlashlight", "Stable Flashlight", "1.0")]
public class StableFlashlight : BaseUnityPlugin
{
    void Awake()
    {
        Logger.LogInfo($"{Info.Metadata.GUID} v{Info.Metadata.Version} has loaded!");
        new Harmony(Info.Metadata.GUID).PatchAll();
    }
}