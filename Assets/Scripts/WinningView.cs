using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinningView : MonoBehaviour
{
    [SerializeField] private TMP_Text _count;
    [SerializeField] private Image _image;

    public void UpdateView(Prize prize)
    {
        if (prize is Coin)
        {
            var coin = (Coin)prize;

            _image.sprite = coin.Sprite;

            if (!_count.gameObject.activeSelf)
                _count.gameObject.SetActive(true);

            _count.text = coin.CountRollWin.ToString();
        }
        else
        {
            if (_count.gameObject.activeSelf)
                _count.gameObject.SetActive(false);

            _image.sprite = prize.Sprite;
        }
    }
}
