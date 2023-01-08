using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public List<AnimatorSetup> animatorSetups;
    public Animator animator;

    public enum AnimatorType
    {
        IDLE,
        RUN,
        DEAD
    }

    public void PlayAnimation(AnimatorType type, float currentSpeed = 1f)
    {
        foreach (var anim in animatorSetups)
        {
            if(anim.type == type)
            {
                animator.SetTrigger(anim.trigger);
                animator.speed = anim.speedAnimation * currentSpeed;
                break;
            }
        }
    }
}

[System.Serializable]
public class AnimatorSetup
{
    public AnimatorManager.AnimatorType type;
    public string trigger;
    public float speedAnimation = 1f;
}