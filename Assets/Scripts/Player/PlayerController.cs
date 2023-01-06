using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform lerpReference;
    public float timeToLerp = 1f;
    public float speedPlayer = 1f;

    private Vector3 _pos;
    private bool _isPlaying = false;

    public void ChangeIsPlaying(bool checkGame)
    {
        _isPlaying = checkGame;
    }

    public void LerpPlayer()
    {
        _pos = lerpReference.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _pos, timeToLerp * Time.deltaTime);
    }

    void PlayerMove()
    {
        if (!_isPlaying) return;

        transform.Translate(transform.forward * Time.deltaTime * speedPlayer);
        LerpPlayer();
    }

    void Update()
    {
        PlayerMove();
    }
}
