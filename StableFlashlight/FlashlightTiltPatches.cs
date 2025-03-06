using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkoid.Repo.StableFlashlight;

[HarmonyPatch(typeof(FlashlightTilt))]
class FlashlightTiltPatches
{
    [HarmonyPrefix, HarmonyPatch("Update")]
    private static bool Update(FlashlightTilt __instance)
    {
        PlayerAvatar? playerAvatar = __instance.GetComponentInParent<FlashlightBob>()?.PlayerAvatar;
        if (!SemiFunc.IsMultiplayer() || (playerAvatar?.photonView.IsMine ?? true))
            return false;

        return true;
    }
}
