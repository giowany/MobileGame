using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAura : MonoBehaviour
{
    public string coinTag = "Coin";

    private void OnTriggerStay(Collider other)
    {
        var coin = other.GetComponent<CollectCoin>();
        if (other.transform.CompareTag(coinTag))
        {
            coin.collect = true;
        }
    }
}
