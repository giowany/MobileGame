using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBase : MonoBehaviour
{
    [Header("Collect Base")]
    public string tagPlayer = "Player";
    public GameObject render;
    public PlayerController playerController;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag(tagPlayer))
        {
            if (playerController == null)
                playerController = collision.GetComponent<PlayerController>();
            Collect();
        }
    }

    protected virtual void Collect()
    {
        if(render != null) render.SetActive(false);
        if (playerController != null) playerController.Bounce();
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        
    }
}
