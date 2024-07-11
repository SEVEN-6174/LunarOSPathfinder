using Microsoft.Xna.Framework;
using Hacknet;
using Hacknet.Gui;

namespace LunarOSPathfinder.Patches
{
    [HarmonyLib.HarmonyPatch(typeof(MainMenu), nameof(MainMenu.DrawBackgroundAndTitle))] // funny text :)
    internal class MainMenuDrawTitle
    {
        static void Prefix(MainMenu __instance)
        {
            TextItem.doFontLabel(new Vector2(__instance.State == MainMenu.MainMenuState.Normal ? 634 : 496, 220), "+ LunarOSPathfinder " + LunarOSMod.ModVer, GuiData.smallfont, new Color(255, 255, 255));
        }
    }
}
