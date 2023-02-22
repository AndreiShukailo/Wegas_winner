using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiningAnimation : MonoBehaviour
{
    [SerializeField] private Sprite _winning;
    [SerializeField] private Sprite _loose;

    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void StartWinningAnimation(bool IsWin)
    {
        _spriteRenderer.sprite = IsWin ? _winning : _loose;
        gameObject.SetActive(true);
    }

    public void SetDisActive()
    {
        gameObject.SetActive(false);
    }
}
