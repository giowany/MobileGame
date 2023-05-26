using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public float timeToLerp = 1f;
    public float speedPlayer = 1f;
    public GameObject collectAura;
    public Transform initPlayerReference;
    public Rigidbody rbPlayer;
    public TouchController touchController;
    public ParticleSystem particle;

    [Header("Animator")]
    public AnimatorManager animatorManager;

    [SerializeField] private BounceHelper _bounceHelper;

    private Vector3 _pos;
    private bool _isPlaying = false;
    private float _currentSpeed;
    private Vector3 _currentPos;
    private Vector3 _posLerpReference;

    public void Bounce()
    {
        if(_bounceHelper != null)
            _bounceHelper.Bounce();
    }

    public void ChangeIsPlaying(bool checkGame)
    {
        _isPlaying = checkGame;
        if(_isPlaying) PlayAnimation(AnimatorManager.AnimatorType.RUN);
    }

    public void PlayAnimation(AnimatorManager.AnimatorType type = AnimatorManager.AnimatorType.IDLE)
    {
        animatorManager.PlayAnimation(type);
        if(type == AnimatorManager.AnimatorType.DEAD)
        {
            transform.DOMoveZ(-1f, .1f).SetRelative();
            particle.Play();
        }
    }
    
    public void ResetAnimation()
    {
        PlayAnimation();
    }

    public void LerpPlayer()
    {
        _pos = touchController.transform.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        if(_pos.x < touchController.limit.x) _pos.x = touchController.limit.x;
        else if(_pos.x > touchController.limit.y) _pos.x = touchController.limit.y;

       transform.position = Vector3.Lerp(transform.position, _pos, timeToLerp * Time.deltaTime);
    }

    void PlayerMove()
    {
        if (!_isPlaying) return;

        transform.Translate(transform.forward * Time.deltaTime * _currentSpeed);
        LerpPlayer();
    }

    public void ResetPosition()
    {
        transform.position = initPlayerReference.position;
        _currentSpeed = speedPlayer;
        _posLerpReference = initPlayerReference.position;
        _posLerpReference.y = touchController.transform.position.y;
        _posLerpReference.z = touchController.transform.position.z;
        touchController.transform.position = _posLerpReference;
        particle.Stop();
    }

    void Update()
    {
        PlayerMove();
    }

    private void Start()
    {
        ResetSpeed();
        _currentPos = transform.position;
        initPlayerReference.position = transform.position;
    }

    #region PowerUps
    public void PowerUpSpeedUp(float PowerSpeed)
    {
        if (_currentSpeed > speedPlayer) return;
        _currentSpeed *= PowerSpeed;
        animatorManager.PlayAnimation(AnimatorManager.AnimatorType.RUN, _currentSpeed / speedPlayer);
    }

    public void ResetSpeed()
    {
        _currentSpeed = speedPlayer;
        if(_isPlaying) animatorManager.PlayAnimation(AnimatorManager.AnimatorType.RUN, _currentSpeed / speedPlayer);
    }

    public void PowerUpFly(float haight, float duration, Ease ease)
    {
        transform.DOMoveY(transform.position.y + haight, duration).SetEase(ease);
    }

    public void ResetHeight(float duration, Ease ease)
    {
        transform.DOMoveY(_currentPos.y, duration).SetEase(ease);
    }
    #endregion
}
