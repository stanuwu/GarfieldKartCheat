using BepInEx;
using BepInEx.Unity.Mono;
using UnityEngine;

namespace GarfieldSpeed;

[BepInPlugin("com.stanuwu.garfieldspeed", "GarfieldSpeed", "1.0.0")]
[BepInProcess("Garfield Kart Furious Racing.exe")]
public class Plugin : BaseUnityPlugin
{
    private GameObject Hook;
    private void Awake()
    {
        Logger.LogInfo($"GarfieldSpeed Hooking...");
        Hook = new GameObject();
        Hook.AddComponent<GarfieldSpeedManager>();
        DontDestroyOnLoad(Hook);
        Logger.LogInfo($"GarfieldSpeed Hooked!");
    }
}
