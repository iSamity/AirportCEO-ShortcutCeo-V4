using AirportCEOModLoader.Core;
using HarmonyLib;
using ShortcutCeo.config;
using UnityEngine;

namespace ShortcutCeo.Patches;

[HarmonyPatch(typeof(GameSettingManager), nameof(GameSettingManager.IsKeyAssigned))]
internal class IsKeyAssignedPatch
{
    internal static void Postfix(KeyCode k, ref bool __result)
    {
        var keyboardShortcut = ConfigManager.IsKeyAssigned(k);

        __result = keyboardShortcut;
    }
}
