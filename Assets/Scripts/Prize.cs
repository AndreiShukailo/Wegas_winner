using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prize : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] protected Sprite _sprite;
    [SerializeField] protected float _minAngle;
    [SerializeField] protected float _maxangle;

    public float minAngle => _minAngle;
    public float _maxAngle => _maxAngle;
    public Sprite Sprite => _sprite;
    public bool IsWin(float angle)
    {
        return angle >= _minAngle && angle <= _maxangle;
    }

    public abstract void AddPrize(List<Prize> prizes);
}
