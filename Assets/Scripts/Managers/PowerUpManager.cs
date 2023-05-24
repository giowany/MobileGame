using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class PowerUpManager : Singleton<PowerUpManager>
{
    public PlayerController playerController;
    public SOPowerUps powerUpsSO;

    public void ResetAll()
    {
        ResetPlayerSpeed();
        ResetHeight();
        EndCollectAura();
    }

    #region Power Up Speed Up
    public void PowerSpeedPlayer()
    {
        playerController.PowerUpSpeedUp(powerUpsSO.PowerUpSpeed);
    }

    public void ResetPlayerSpeed()
    {
        playerController.ResetSpeed();
    }
    #endregion

    #region Power Up Fly
    public void StartPowerUpFly()
    {
        playerController.PowerUpFly(powerUpsSO.heightFly, powerUpsSO.duration, powerUpsSO.ease);
    }

    public void ResetHeight()
    {
        playerController.ResetHeight(powerUpsSO.duration, powerUpsSO.ease);
    }
    #endregion

    #region Power Up Imã
    public void StartCollectAura()
    {
        playerController.collectAura.SetActive(true);
    }

    public void EndCollectAura()
    {
        playerController.collectAura.SetActive(false);
    }
    #endregion
}
