using System;
using Aube;
using UnityEngine;
using Logger = BepInEx.Logging.Logger;

namespace GarfieldSpeed;

public class GarfieldSpeedManager : MonoBehaviour
{
    private void Update()
    {
        GameManager gameManager = GameManager.Instance;
        if(gameManager == null) return;
        if(gameManager.GameMode == null) return;
        Kart playerKart = gameManager.GameMode.GetKart(0);
        if(playerKart == null) return;
        if (playerKart.BonusMgr.GetItem(0) != BonusCategory.PARFUME)
        {
            playerKart.BonusMgr.SetItem(BonusCategory.PARFUME, 99);
            Logger.CreateLogSource("GS").LogInfo("Give Parfume");   
        }
        if (!playerKart.IsBoosting())
        {
            playerKart.Boost(100, 0, 1000, 5, true, true);  
            Logger.CreateLogSource("GS").LogInfo("Boost");   
        }
    }
}