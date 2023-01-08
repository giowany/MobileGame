using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpIma : PowerUpBase
{
    protected override void StartPowerUp()
    {
        PowerUpManager.instance.StartCollectAura();
        base.StartPowerUp();
    }

    protected override void EndPowerUp()
    {
        PowerUpManager.instance.EndCollectAura();
        base.EndPowerUp();
    }
}
