using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPUPiece : MonoBehaviour
{
    public GameObject powerUp;

    public void SpawPowerUp(GameObject powerUpPiece)
    {
        if (powerUp != null) Destroy(powerUp);

        powerUp = Instantiate(powerUpPiece, transform);
        powerUp.transform.localPosition = Vector3.zero;
    }
}
