using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform lerpReference;
    public float timeToLerp = 1f;
    public float speedPlayer = 1f;

    private Vector3 _pos;

    public void LerpPlayer()
    {
        _pos = lerpReference.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _pos, timeToLerp * Time.deltaTime);
    }

    void PlayerMove()
    {
        transform.Translate(transform.forward * Time.deltaTime * speedPlayer);
    }

    void Update()
    {
        LerpPlayer();
        PlayerMove();
    }
}
