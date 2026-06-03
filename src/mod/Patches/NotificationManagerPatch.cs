using HarmonyLib;
using Manager;
using SolarExpanseLaunchWindows.UI;

namespace SolarExpanseLaunchWindows.Patches
{
    [HarmonyPatch(typeof(NotificationManager), "Awake")]
    internal static class NotificationManagerPatch
    {
        [HarmonyPostfix]
        static void Postfix(NotificationManager __instance)
        {
            Plugin.Log.LogInfo("[LW] NotificationManager.Awake postfix — injecting");
            LaunchWindowInjector.Inject(__instance);
        }
    }
}
