using AirportCEOModLoader.Core;
using BepInEx.Configuration;
using ShortcutCeo.libs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortcutCeo.config;

internal class GameConfig
{
    static ConfigEntry<KeyboardShortcut> CameraUp;
    static ConfigEntry<KeyboardShortcut> CameraLeft;
    static ConfigEntry<KeyboardShortcut> CameraDown;
    static ConfigEntry<KeyboardShortcut> CameraRight;


    static ConfigEntry<KeyboardShortcut> Rotate;
    static ConfigEntry<KeyboardShortcut> RotateRight;
    static ConfigEntry<KeyboardShortcut> RotateLeft;

    static ConfigEntry<KeyboardShortcut> ZoomIn;
    static ConfigEntry<KeyboardShortcut> ZoomOut;

    static ConfigEntry<KeyboardShortcut> Pause;
    static ConfigEntry<KeyboardShortcut> NormalTime;
    static ConfigEntry<KeyboardShortcut> DoubleTime;
    static ConfigEntry<KeyboardShortcut> TripleTime;
    static ConfigEntry<KeyboardShortcut> HalfTime;

    static ConfigEntry<KeyboardShortcut> ToggleManagementPanel;
    static ConfigEntry<KeyboardShortcut> ToggleFlightPlanner;
    static ConfigEntry<KeyboardShortcut> ToggleFlightProcess;
    static ConfigEntry<KeyboardShortcut> ToggleZones;
    static ConfigEntry<KeyboardShortcut> ToggleRooms;
    static ConfigEntry<KeyboardShortcut> ToggleTaxiways;
    static ConfigEntry<KeyboardShortcut> ToggleQueues;
    static ConfigEntry<KeyboardShortcut> ToggleBaggage;
    static ConfigEntry<KeyboardShortcut> ToggleBulldozer;
    static ConfigEntry<KeyboardShortcut> ToggleFrontTutorialPanel;
    static ConfigEntry<KeyboardShortcut> TogglePlanning;
    static ConfigEntry<KeyboardShortcut> ToggleTerminals;
    static ConfigEntry<KeyboardShortcut> FloorUp;
    static ConfigEntry<KeyboardShortcut> FloorDown;

    internal static void SetupConfig()
    {
        CameraUp = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.move-camera-up"), new KeyboardShortcut(GameSettingManager.CameraUp), SetupAdvancedConfigDescription(1));
        CameraLeft = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.move-camera-left"), new KeyboardShortcut(GameSettingManager.CameraLeft), SetupAdvancedConfigDescription(2));
        CameraDown = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.move-camera-down"), new KeyboardShortcut(GameSettingManager.CameraDown), SetupAdvancedConfigDescription(3));
        CameraRight = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.move-camera-right"), new KeyboardShortcut(GameSettingManager.CameraRight), SetupAdvancedConfigDescription(4));


        Rotate = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.rotate"), new KeyboardShortcut(GameSettingManager.Rotate), SetupAdvancedConfigDescription(5));
        RotateRight = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.rotate-right"), new KeyboardShortcut(GameSettingManager.RotateRight), SetupAdvancedConfigDescription(6));
        RotateLeft = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.rotate-left"), new KeyboardShortcut(GameSettingManager.RotateLeft), SetupAdvancedConfigDescription(7));

        ZoomIn = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.zoom-in"), new KeyboardShortcut(GameSettingManager.ZoomIn), SetupAdvancedConfigDescription(8));
        ZoomOut = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.zoom-out"), new KeyboardShortcut(GameSettingManager.ZoomOut), SetupAdvancedConfigDescription(9));

        Pause = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.pause"), new KeyboardShortcut(GameSettingManager.Pause), SetupAdvancedConfigDescription(10));
        NormalTime = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.normal-time"), new KeyboardShortcut(GameSettingManager.NormalTime), SetupAdvancedConfigDescription(11));
        DoubleTime = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.double-time"), new KeyboardShortcut(GameSettingManager.DoubleTime), SetupAdvancedConfigDescription(12));
        TripleTime = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.triple-time"), new KeyboardShortcut(GameSettingManager.TripleTime), SetupAdvancedConfigDescription(13));
        HalfTime = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.half-time"), new KeyboardShortcut(GameSettingManager.HalfTime), SetupAdvancedConfigDescription(14));

        ToggleManagementPanel = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-management-panel"), new KeyboardShortcut(GameSettingManager.ToggleManagementPanel), SetupAdvancedConfigDescription(15));
        ToggleFlightPlanner = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-flight-planner"), new KeyboardShortcut(GameSettingManager.ToggleFlightPlanner), SetupAdvancedConfigDescription(16));
        ToggleFlightProcess = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-flight-process"), new KeyboardShortcut(GameSettingManager.ToggleFlightProcess), SetupAdvancedConfigDescription(17));
        ToggleZones = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-zones"), new KeyboardShortcut(GameSettingManager.ToggleZones), SetupAdvancedConfigDescription(18));
        ToggleRooms = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-rooms"), new KeyboardShortcut(GameSettingManager.ToggleRooms), SetupAdvancedConfigDescription(19));
        ToggleTaxiways = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-taxiways"), new KeyboardShortcut(GameSettingManager.ToggleTaxiways), SetupAdvancedConfigDescription(20));
        ToggleQueues = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-queues"), new KeyboardShortcut(GameSettingManager.ToggleQueues), SetupAdvancedConfigDescription(21));
        ToggleBaggage = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-baggage"), new KeyboardShortcut(GameSettingManager.ToggleBaggage), SetupAdvancedConfigDescription(22));
        ToggleBulldozer = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-bulldozer"), new KeyboardShortcut(GameSettingManager.ToggleBulldozer), SetupAdvancedConfigDescription(23));
        ToggleFrontTutorialPanel = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.toggle-front-tutorial-panel"), new KeyboardShortcut(GameSettingManager.ToggleFrontTutorialPanel), SetupAdvancedConfigDescription(24));
        TogglePlanning = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("generic.key.2"), new KeyboardShortcut(GameSettingManager.TogglePlanning), SetupAdvancedConfigDescription(25));

        ToggleTerminals = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("interaction-panel.key.toggle-terminals"), new KeyboardShortcut(GameSettingManager.ToggleTerminals), new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 26 }));

        FloorUp = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.floor-up"), new KeyboardShortcut(GameSettingManager.FloorUp), SetupAdvancedConfigDescription(27));
        FloorDown = ConfigReference.Bind("General", LocalizationManager.GetLocalizedValue("input.key.floor-down"), new KeyboardShortcut(GameSettingManager.FloorDown), SetupAdvancedConfigDescription(28));


        CameraUp.SettingChanged += SettingChanged;
        CameraLeft.SettingChanged += SettingChanged;
        CameraDown.SettingChanged += SettingChanged;
        CameraRight.SettingChanged += SettingChanged;
        Rotate.SettingChanged += SettingChanged;
        RotateRight.SettingChanged += SettingChanged;
        RotateLeft.SettingChanged += SettingChanged;
        ZoomIn.SettingChanged += SettingChanged;
        ZoomOut.SettingChanged += SettingChanged;
        Pause.SettingChanged += SettingChanged;
        NormalTime.SettingChanged += SettingChanged;
        DoubleTime.SettingChanged += SettingChanged;
        TripleTime.SettingChanged += SettingChanged;
        HalfTime.SettingChanged += SettingChanged;
        ToggleManagementPanel.SettingChanged += SettingChanged;
        ToggleFlightPlanner.SettingChanged += SettingChanged;
        ToggleFlightProcess.SettingChanged += SettingChanged;
        ToggleZones.SettingChanged += SettingChanged;
        ToggleRooms.SettingChanged += SettingChanged;
        ToggleTaxiways.SettingChanged += SettingChanged;
        ToggleQueues.SettingChanged += SettingChanged;
        ToggleBaggage.SettingChanged += SettingChanged;
        ToggleBulldozer.SettingChanged += SettingChanged;
        ToggleFrontTutorialPanel.SettingChanged += SettingChanged;
        TogglePlanning.SettingChanged += SettingChanged;
        ToggleTerminals.SettingChanged += SettingChanged;
        FloorUp.SettingChanged += SettingChanged;
        FloorDown.SettingChanged += SettingChanged;


        try
        {
            ConfigManager.AddShortcut(CameraUp);
            ConfigManager.AddShortcut(CameraLeft);
            ConfigManager.AddShortcut(CameraDown);
            ConfigManager.AddShortcut(CameraRight);


            ConfigManager.AddShortcut(Rotate);
            ConfigManager.AddShortcut(RotateRight);
            ConfigManager.AddShortcut(RotateLeft);

            ConfigManager.AddShortcut(ZoomIn);
            ConfigManager.AddShortcut(ZoomOut);

            ConfigManager.AddShortcut(Pause);
            ConfigManager.AddShortcut(NormalTime);
            ConfigManager.AddShortcut(DoubleTime);
            ConfigManager.AddShortcut(TripleTime);
            ConfigManager.AddShortcut(HalfTime);

            ConfigManager.AddShortcut(ToggleManagementPanel);
            ConfigManager.AddShortcut(ToggleFlightPlanner);
            ConfigManager.AddShortcut(ToggleFlightProcess);
            ConfigManager.AddShortcut(ToggleZones);
            ConfigManager.AddShortcut(ToggleRooms);
            ConfigManager.AddShortcut(ToggleTaxiways);
            ConfigManager.AddShortcut(ToggleQueues);
            ConfigManager.AddShortcut(ToggleBaggage);
            ConfigManager.AddShortcut(ToggleBulldozer);
            ConfigManager.AddShortcut(ToggleFrontTutorialPanel);
            ConfigManager.AddShortcut(TogglePlanning);

            ConfigManager.AddShortcut(ToggleTerminals);

            ConfigManager.AddShortcut(FloorUp);
            ConfigManager.AddShortcut(FloorDown);
        }
        catch (Exception ex)
        {
            Plugin.Logger.LogError("Failed to sync game shortcuts: " + ExceptionUtils.ProccessException(ex));
        }
    }

    internal static void SyncGameShortCuts()
    {
        CameraUp.Value = new KeyboardShortcut(GameSettingManager.CameraUp);
        CameraLeft.Value = new KeyboardShortcut(GameSettingManager.CameraLeft);
        CameraDown.Value = new KeyboardShortcut(GameSettingManager.CameraDown);
        CameraRight.Value = new KeyboardShortcut(GameSettingManager.CameraRight);

        Rotate.Value = new KeyboardShortcut(GameSettingManager.Rotate);
        RotateRight.Value = new KeyboardShortcut(GameSettingManager.RotateRight);
        RotateLeft.Value = new KeyboardShortcut(GameSettingManager.RotateLeft);

        ZoomIn.Value = new KeyboardShortcut(GameSettingManager.ZoomIn);
        ZoomOut.Value = new KeyboardShortcut(GameSettingManager.ZoomOut);

        Pause.Value = new KeyboardShortcut(GameSettingManager.Pause);
        NormalTime.Value = new KeyboardShortcut(GameSettingManager.NormalTime);
        DoubleTime.Value = new KeyboardShortcut(GameSettingManager.DoubleTime);
        TripleTime.Value = new KeyboardShortcut(GameSettingManager.TripleTime);
        HalfTime.Value = new KeyboardShortcut(GameSettingManager.HalfTime);

        ToggleManagementPanel.Value = new KeyboardShortcut(GameSettingManager.ToggleManagementPanel);
        ToggleFlightPlanner.Value = new KeyboardShortcut(GameSettingManager.ToggleFlightPlanner);
        ToggleFlightProcess.Value = new KeyboardShortcut(GameSettingManager.ToggleFlightProcess);
        ToggleZones.Value = new KeyboardShortcut(GameSettingManager.ToggleZones);
        ToggleRooms.Value = new KeyboardShortcut(GameSettingManager.ToggleRooms);
        ToggleTaxiways.Value = new KeyboardShortcut(GameSettingManager.ToggleTaxiways);
        ToggleQueues.Value = new KeyboardShortcut(GameSettingManager.ToggleQueues);
        ToggleBaggage.Value = new KeyboardShortcut(GameSettingManager.ToggleBaggage);
        ToggleBulldozer.Value = new KeyboardShortcut(GameSettingManager.ToggleBulldozer);
        ToggleFrontTutorialPanel.Value = new KeyboardShortcut(GameSettingManager.ToggleFrontTutorialPanel);
        TogglePlanning.Value = new KeyboardShortcut(GameSettingManager.TogglePlanning);

        ToggleTerminals.Value = new KeyboardShortcut(GameSettingManager.ToggleTerminals);

        FloorUp.Value = new KeyboardShortcut(GameSettingManager.FloorUp);
        FloorDown.Value = new KeyboardShortcut(GameSettingManager.FloorDown);
    }

    private static void SettingChanged(object sender, EventArgs e)
    {
        if (e is SettingChangedEventArgs settingChangedArgs)
        {
            var x = new List<ConfigEntry<KeyboardShortcut>> {
                CameraUp,
                CameraLeft,
                CameraDown,
                CameraRight,


                Rotate,
                RotateRight,
                RotateLeft,

                ZoomIn,
                ZoomOut,

                Pause,
                NormalTime,
                DoubleTime,
                TripleTime,
                HalfTime,

                ToggleManagementPanel,
                ToggleFlightPlanner,
                ToggleFlightProcess,
                ToggleZones,
                ToggleRooms,
                ToggleTaxiways,
                ToggleQueues,
                ToggleBaggage,
                ToggleBulldozer,
                ToggleFrontTutorialPanel,
                TogglePlanning,
                ToggleTerminals,
                FloorUp,
                FloorDown,
            };

            var hasKeyAssigned = x.Find(y => ConfigManager.IsKeyAssigned(y.Value.MainKey));

            if(hasKeyAssigned != null)
            {
                DialogUtils.QueueDialog(LocalizationManager.GetLocalizedValue("input.key.already-assigned-message"));
                // settingChangedArgs.ChangedSetting.Definition.Key
                // TODO: Revert to previous value
                hasKeyAssigned.Value = KeyboardShortcut.Empty;
                return;
            }

            SyncConfigWithGame();
        }
    }

    private static void SyncConfigWithGame()
    {
        GameSettingManager.CameraUp = CameraUp.Value.MainKey;
        GameSettingManager.CameraLeft = CameraLeft.Value.MainKey;
        GameSettingManager.CameraDown = CameraDown.Value.MainKey;
        GameSettingManager.CameraRight = CameraRight.Value.MainKey;

        GameSettingManager.Rotate = Rotate.Value.MainKey;
        GameSettingManager.RotateRight = RotateRight.Value.MainKey;
        GameSettingManager.RotateLeft = RotateLeft.Value.MainKey;

        GameSettingManager.ZoomIn = ZoomIn.Value.MainKey;
        GameSettingManager.ZoomOut = ZoomOut.Value.MainKey;

        GameSettingManager.Pause = Pause.Value.MainKey;
        GameSettingManager.NormalTime = NormalTime.Value.MainKey;
        GameSettingManager.DoubleTime = DoubleTime.Value.MainKey;
        GameSettingManager.TripleTime = TripleTime.Value.MainKey;
        GameSettingManager.HalfTime = HalfTime.Value.MainKey;

        GameSettingManager.ToggleManagementPanel = ToggleManagementPanel.Value.MainKey;
        GameSettingManager.ToggleFlightPlanner = ToggleFlightPlanner.Value.MainKey;
        GameSettingManager.ToggleFlightProcess = ToggleFlightProcess.Value.MainKey;
        GameSettingManager.ToggleZones = ToggleZones.Value.MainKey;
        GameSettingManager.ToggleRooms = ToggleRooms.Value.MainKey;
        GameSettingManager.ToggleTaxiways = ToggleTaxiways.Value.MainKey;
        GameSettingManager.ToggleQueues = ToggleQueues.Value.MainKey;
        GameSettingManager.ToggleBaggage = ToggleBaggage.Value.MainKey;
        GameSettingManager.ToggleBulldozer = ToggleBulldozer.Value.MainKey;
        GameSettingManager.ToggleFrontTutorialPanel = ToggleFrontTutorialPanel.Value.MainKey;
        GameSettingManager.TogglePlanning = TogglePlanning.Value.MainKey;

        GameSettingManager.ToggleTerminals = ToggleTerminals.Value.MainKey;

        GameSettingManager.FloorUp = FloorUp.Value.MainKey;
        GameSettingManager.FloorDown = FloorDown.Value.MainKey;
    }

    private static ConfigDescription SetupAdvancedConfigDescription(int order)
    {
        return new ConfigDescription("", null, new ConfigurationManagerAttributes { IsAdvanced = true, Order = order });
    }

    static ConfigFile ConfigReference => ShortcutCeo.Plugin.ConfigReference;
}
