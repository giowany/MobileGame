using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EBAC.Core.Singleton;

public class ItemManager : Singleton<ItemManager> 
{
    public TextMeshProUGUI textCoins;
    public SOInt soInt;
    public void AddCoins(int amount = 1)
    {
        soInt.Value += amount;
        textCoins.text = "X" + soInt.Value.ToString();
    }

    private void ResetItens()
    {
        soInt.Value = 0;
    }

    private void Start()
    {
        ResetItens();
    }
}
