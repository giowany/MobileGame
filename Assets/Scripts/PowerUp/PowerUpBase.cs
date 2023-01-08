using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : CollectBase
{
    [Header("Power Up Base")]
    public float timaToEnd = 3f;

    protected virtual void StartPowerUp()
    {
        Invoke(nameof(EndPowerUp), timaToEnd);
    }

    protected virtual void EndPowerUp()
    {
        
    }

    protected override void OnCollect()
    {
        base.OnCollect();
        StartPowerUp();
    }
}
