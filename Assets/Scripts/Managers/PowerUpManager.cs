using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class PowerUpManager : Singleton<PowerUpManager>
{
    public PlayerController PlayerController;
    public SOPowerUps powerUpsSO;

    #region Power Up Speed Up
    public void PowerSpeedPlayer()
    {
        PlayerController.PowerUpSpeedUp(powerUpsSO.PowerUpSpeed);
    }

    public void ResetPlayerSpeed()
    {
        PlayerController.ResetSpeed();
    }
    #endregion

    #region Power Up Fly
    public void StartPowerUpFly()
    {
        PlayerController.PowerUpFly(powerUpsSO.heightFly, powerUpsSO.duration, powerUpsSO.ease);
    }

    public void ResetHeight()
    {
        PlayerController.ResetHeight(powerUpsSO.duration, powerUpsSO.ease);
    }
    #endregion

    #region Power Up Imã
    public void StartCollectAura()
    {
        PlayerController.collectAura.SetActive(true);
    }

    public void EndCollectAura()
    {
        PlayerController.collectAura.SetActive(false);
    }
    #endregion
}
