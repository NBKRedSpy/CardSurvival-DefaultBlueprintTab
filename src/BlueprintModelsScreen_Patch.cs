using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace DefaultBluePrintTab
{
    [HarmonyPatch(typeof(BlueprintModelsScreen), "ShowTab")]
    public static class BlueprintModelsScreen_Patch
    {

        /// <summary>
        /// True if the last selected subtab was research.
        /// </summary>
        private static bool LastSubTabIsResearch;

        public static MethodInfo ShowSubTab = AccessTools.Method(typeof(BlueprintModelsScreen), "ShowSubTab", new Type[] { typeof(int) });

        public static void Prefix(BlueprintModelsScreen __instance)
        {
            LastSubTabIsResearch = __instance.CurrentSubTab == -1;
        }
        public static void Postfix(BlueprintModelsScreen __instance)
        {
            if(LastSubTabIsResearch || Plugin.AlwaysStartWithResearchTab)
            {
                __instance.CurrentSubTab = -1;
                ShowSubTab.Invoke(__instance, new object[] { -1 });
            }
        }

    }
}
