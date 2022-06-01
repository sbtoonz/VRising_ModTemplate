using System;
using BepInEx;
using BepInEx.IL2CPP;

namespace TestVrising
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Class1 : BasePlugin
    {
        public override void Load()
        {
            
        }
    }
    
    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "Vrising_Mod";
        public const string PLUGIN_NAME = "Vrising_Mod";
        public const string PLUGIN_VERSION = "1.0.0";
    }
}