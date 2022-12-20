using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace DefaultBluePrintTab;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static ManualLogSource Log { get; set; }
    public static bool AlwaysStartWithResearchTab { get; set; }

    private void Awake()
    {

        Log = Logger;

        AlwaysStartWithResearchTab = Config.Bind("General", nameof(AlwaysStartWithResearchTab), false,
            "If true will always change the sub tab to Research on tab click.  Otherwise, will only keep the research sub tab " +
            "open if the previous tab had the Research sub tab open").Value;

        Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();

    }

    public static void LogInfo(string text)
    {
        Plugin.Log.LogInfo(text);
    }

}
