using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using ShortcutCeo.config;

namespace ShortcutCeo;

[BepInPlugin("org.iSamity.plugins." + MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency("org.airportceomodloader.humoresque")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    internal static Harmony Harmony { get; private set; }
    internal static ConfigFile ConfigReference { get; private set; }

    void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loading!");

        ConfigReference = Config;

        SetupHarmony();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is done!");
    }

    void Start()
    {
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is setting up config.");

        ConfigManager.Setup();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} finished setting up config.");

        AirportCEOModLoader.WatermarkUtils.WatermarkUtils.Register(new AirportCEOModLoader.WatermarkUtils.WatermarkInfo("ShC", MyPluginInfo.PLUGIN_VERSION, true));
    }   

    void Update()
    {
        if (!SaveLoadGameDataController.loadComplete) 
        { 
            return;   
        }

        foreach (var kvp in ConfigManager.GetShortcuts())
        {
            if (kvp.Value != null && kvp.Key.Value.IsDown())
            {
                kvp.Value.Invoke();
            }
        }
    }

    private void SetupHarmony()
    {
        Harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        Harmony.PatchAll();
    }
}
