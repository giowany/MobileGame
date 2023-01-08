using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu]
public class SOPowerUps : ScriptableObject
{
    [Header("Power Up Speed Up")]
    public float PowerUpSpeed;

    [Header("Power Up Fly")]
    public float heightFly;
    public float duration;
    public Ease ease;

    [Header("Power Up Imã")]
    public float timeToLerp;
}
