using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class VFXManager : Singleton<VFXManager>
{
    public ParticleSystem vfxCoin;
    public ParticleSystem vfxImpact;

    public List<Transform> coins;

    private void Awake()
    {
        if (coins != null)
        {
            foreach (Transform t in coins)
            {
                var c = Instantiate(vfxCoin);
                c.transform.SetParent(t.transform);
                c.transform.position = t.transform.position;
            }
        }

    }
}
