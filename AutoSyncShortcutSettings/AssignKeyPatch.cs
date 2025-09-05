#nullable enable

using HarmonyLib;
using ShortcutCeo.config;
using UnityEngine;

namespace ShortcutCeo.AutoSyncShortcutSettings;

[HarmonyPatch(typeof(ControlSettingPanel), nameof(ControlSettingPanel.AssignKey))]
internal class AssignKeyPatch
{
    // Update our config if the key assignment was successful
    [HarmonyPostfix]
    internal static void AssignKeyPostfix(string keyIdentifyer, KeyCode key)
    {
        GameConfig.SyncGameShortCuts();
    }
}
