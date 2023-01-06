using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public string tagPlayer = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(tagPlayer))
        {
            GameManager.instance.StartGame(false);
            GameManager.instance.ShowFinalScreen();
        }
    }
}
