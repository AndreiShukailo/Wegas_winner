using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private WiningAnimation _winningAnimation;

    public UnityAction<bool> WiningAnimation;

    private void OnEnable()
    {
        WiningAnimation += _winningAnimation.StartWinningAnimation;
    }

    public void OnDisable()
    {
        WiningAnimation -= _winningAnimation.StartWinningAnimation;
    }
}
