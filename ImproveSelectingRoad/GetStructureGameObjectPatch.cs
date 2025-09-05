using HarmonyLib;
using UnityEngine;

namespace ShortcutCeo.ImproveSelectingRoad;

[HarmonyPatch(typeof(BuildingController), nameof(BuildingController.GetStructureGameObject), [typeof(Enums.StructureType)])]
internal static class GetStructureGameObjectPatch
{
    [HarmonyPostfix]
    internal static void Postfix(BuildingController __instance, ref GameObject __result)
    {
        if (SharedPatchData.placeableRoad != null && __result == __instance.road)
        {
            var correctRoadType = __instance.DetermineRoadType(SharedPatchData.placeableRoad.roadType);

            __result = correctRoadType;
        }
    }
}
