using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceHelper : MonoBehaviour
{
    [Header("Animation Setings")]
    public float scaleDuration = .1f;
    public float scaleBounce = 1.2f;
    public Ease ease;

    public void Bounce()
    {
        transform.localScale = Vector3.one;
        transform.DOScale(scaleBounce, scaleDuration).SetEase(ease).SetLoops(2, LoopType.Yoyo);
    }


}
