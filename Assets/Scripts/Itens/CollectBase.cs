using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBase : MonoBehaviour
{
    [Header("Collect Base")]
    public string tagPlayer = "Player";
    public GameObject render;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag(tagPlayer))
        {
            Collect();
        }
    }

    protected virtual void Collect()
    {
        if(render != null) render.SetActive(false);
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        
    }
}
