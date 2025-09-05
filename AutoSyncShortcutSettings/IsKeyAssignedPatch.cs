using HarmonyLib;
using ShortcutCeo.config;
using UnityEngine;

namespace ShortcutCeo.AutoSyncShortcutSettings;

[HarmonyPatch(typeof(GameSettingManager), nameof(GameSettingManager.IsKeyAssigned))]
internal class IsKeyAssignedPatch
{
    internal static void Postfix(KeyCode k, ref bool __result)
    {
        var keyIdentifyer = Singleton<ControlSettingPanel>.Instance.keyIdentifyer;

        if(keyIdentifyer == null)
        {
            return;
        }

        var keyBoardShortcut = GameConfig.ToKeyboardShortcut(keyIdentifyer);

        if(keyBoardShortcut == null)
        {
            return;
        }

        var keyboardShortcut = ConfigManager.IsKeyAssigned(k, keyBoardShortcut.Definition.Key);

        __result = keyboardShortcut;
    }    
}
