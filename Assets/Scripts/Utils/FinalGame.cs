using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGame : MonoBehaviour
{
    public string checkPlayerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag(checkPlayerTag))
        {
            GameManager.instance.StartGame(false);
            GameManager.instance.ShowFinalScreen();
        }
   }
}
