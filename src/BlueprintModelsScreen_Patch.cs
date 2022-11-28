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
        public static MethodInfo ShowSubTab = AccessTools.Method(typeof(BlueprintModelsScreen), "ShowSubTab", new Type[] { typeof(int) });

        public static void Postfix(BlueprintModelsScreen __instance)
        {
            __instance.CurrentSubTab = -1;
            ShowSubTab.Invoke(__instance, new object[] { -1 });
        }

    }
}
