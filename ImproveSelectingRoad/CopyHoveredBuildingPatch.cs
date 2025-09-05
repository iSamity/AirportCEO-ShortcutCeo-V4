using HarmonyLib;
using System.Collections.Generic;

namespace ShortcutCeo.ImproveSelectingRoad;

// Renamed to clearly indicate its purpose
[HarmonyPatch(typeof(SelectionController), nameof(SelectionController.CopyHoveredBuilding))]
internal static class CopyHoveredBuildingPatch
{
    [HarmonyPrefix]
    internal static bool Prefix(SelectionController __instance)
    {
        List<PlaceableObject> listOfAllObjectsFromVector = SingletonNonDestroy<GridController>.Instance.GetListOfAllObjectsFromVector<PlaceableObject>(__instance.mousePosition.ToVector3(FloorManager.currentFloor));
        for (int i = 0; i < listOfAllObjectsFromVector.Count; i++)
        {
            PlaceableObject placeableObject = listOfAllObjectsFromVector[i];

            if (placeableObject is PlaceableStructure placeableStructure && placeableStructure is PlaceableRoad _placeableRoad)
            {
                SharedPatchData.placeableRoad = _placeableRoad;
            }
        }
        return true;
    }

    [HarmonyPostfix]
    internal static void Postfix(SelectionController __instance)
    {
        SharedPatchData.placeableRoad = null;
    }
}
