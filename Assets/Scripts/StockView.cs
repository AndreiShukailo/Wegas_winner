using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class StockView : MonoBehaviour
{
    [SerializeField] private List<CoinView> _coins;


    private void Start()
    {
        foreach (var item in _coins)
        {
            item.SetCoininView();
        }
    }

    public void UpdateCoinsInView()
    {
        foreach (var item in _coins)
        {
            item.UpdateCoinView();
        }
    }
}

[Serializable]
public class CoinView
{
    [SerializeField] private Coin Coin;
    [SerializeField] public Image Image;
    [SerializeField] public TMP_Text Count;

    public void SetCoininView()
    {
        Image.sprite = Coin.Sprite;
        Count.text = Coin.Count.ToString();
    }

    public void UpdateCoinView()
    {
        Count.text = Coin.Count.ToString();
    }
}
