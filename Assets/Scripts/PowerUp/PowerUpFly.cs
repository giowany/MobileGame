using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFly : PowerUpBase
{
    protected override void StartPowerUp()
    {
        PowerUpManager.instance.StartPowerUpFly();
        base.StartPowerUp();
    }

    protected override void EndPowerUp()
    {
        PowerUpManager.instance.ResetHeight();
        base.EndPowerUp();
    }
}
