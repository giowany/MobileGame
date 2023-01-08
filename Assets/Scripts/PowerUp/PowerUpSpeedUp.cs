using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeedUp : PowerUpBase
{
    protected override void StartPowerUp()
    {
        PowerUpManager.instance.PowerSpeedPlayer();
        base.StartPowerUp();
    }

    protected override void EndPowerUp()
    {
        PowerUpManager.instance.ResetPlayerSpeed();
        base.EndPowerUp();
    }
}
