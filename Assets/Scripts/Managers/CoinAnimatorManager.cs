using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;
using DG.Tweening;

public class CoinAnimatorManager : Singleton<CoinAnimatorManager>
{
    public List<CollectCoin> collectCoinList;

    [Header("Animation Setings")]
    public float durationAnimation = .1f;
    public float delayAnimation = .1f;
    public Ease ease;

    void Start()
    {
        collectCoinList = new List<CollectCoin>();   
    }

    public void StartAnimations()
    {
        StartCoroutine(ScalePieces());
    }

    public void RegisterCoin(CollectCoin c)
    {
        if (!collectCoinList.Contains(c))
        {
            collectCoinList.Add(c);
            c.transform.localScale = Vector3.zero;
        }
    }

    public void ClearListPieces()
    {
        for (int i = collectCoinList.Count - 1; i >= 0; i--)
        {
            Destroy(collectCoinList[i].gameObject);
        }

        collectCoinList.Clear();
    }

    IEnumerator ScalePieces()
    {
        foreach (var p in collectCoinList)
        {
            p.transform.localScale = Vector3.zero;
        }
        Sort();
        yield return null;

        for (int i = 0; i < collectCoinList.Count; i++)
        {
            collectCoinList[i].transform.DOScale(1, durationAnimation).SetEase(ease);
            yield return new WaitForSeconds(delayAnimation);

        }

    }

    private void Sort()
    {
        collectCoinList = collectCoinList.OrderBy(x => Vector3.Distance(this.transform.position, x.transform.position)).ToList();
    }
}
