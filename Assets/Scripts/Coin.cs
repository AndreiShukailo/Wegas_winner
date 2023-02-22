using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Prize", menuName = "Prize", order = 51)]
public class Coin : Prize
{
    [SerializeField] private int _count;
    [SerializeField] private int _countWinning;

    public int CountRollWin => _countWinning;
    public int Count => _count;

    public override void AddPrize(List<Prize> prizes)
    {
        foreach (var item in prizes)
        {
            if(item is Coin && item == this)
            { 
                _count += _countWinning;
                break;
            }
        }
    }

    public void SetZeroCount()
    {
        _count = 0;
    }


}
