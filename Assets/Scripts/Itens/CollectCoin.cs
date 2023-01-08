using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : CollectBase
{
    [SerializeField]private ParticleSystem _coin;
    public AudioSource coinAudioSource;
    public float timeToLerp = 1f;
    public bool collect = false;

    private void Start()
    {
        _coin = GetComponentInChildren<ParticleSystem>();
    }

    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.instance.AddCoins();
        if(_coin != null) _coin.Play();
        if(coinAudioSource != null) coinAudioSource.Play();
    }

    private void Update()
    {
        if(collect)
            transform.position = Vector3.Lerp(transform.position, PowerUpManager.instance.playerController.transform.position, timeToLerp * Time.deltaTime);
    }

}
