using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkoid.Repo.StableFlashlight;

[HarmonyPatch(typeof(FlashlightBob))]
class FlashlightBobPatches
{
    [HarmonyPrefix, HarmonyPatch("Update")]
    private static bool Update(FlashlightBob __instance)
    {
        if (!SemiFunc.IsMultiplayer() || __instance.PlayerAvatar.photonView.IsMine)
            return false;

        return true;
    }
}
